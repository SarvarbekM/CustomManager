using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class FEACNForm : Form
    {
        List<FEACN> allFEACN;
        List<FEACN> filteredFEACN;

        public FEACNForm()
        {
            InitializeComponent();
            allFEACN = new List<FEACN>();
            filteredFEACN = new List<FEACN>();
        }

        private void FEACNForm_Load(object sender, EventArgs e)
        {
            LoadFEACNAsync();
        }

        private async void LoadFEACNAsync()
        {
            metroProgressSpinner1.Visible = true;
            fEACNBindingSource.DataSource = null;
            dataGridView1.Refresh();
            allFEACN.Clear();
            Task<bool> task = Task.Run(() => loadFEACN());
            bool answer = await task;
            if (answer)
            {
                PrintFEACN(string.Empty);
            }
            else
            {
                MessageBox.Show("FEACN not loaded, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            metroProgressSpinner1.Visible = false;
        }

        private bool loadFEACN()
        {
            string url = MyGlobalClass.Host + "feacn/read.php";
            string json = MyGlobalClass.GetResponsible(url);
            return MyGlobalClass.TryConvert(json, ref allFEACN);
        }

        private void PrintFEACN(string searchText)
        {
            fEACNBindingSource.DataSource = null;
            dataGridView1.Refresh();
            filteredFEACN.Clear();
            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (FEACN item in allFEACN)
                {
                    if (item.FEACN_Code.Contains(searchText) || item.FEACN_Name.Contains(searchText))
                    {
                        filteredFEACN.Add(item);
                    }
                }
            }
            else
            {
                foreach (FEACN item in allFEACN)
                {
                    filteredFEACN.Add(item);
                }
            }
            fEACNBindingSource.DataSource = filteredFEACN;
            dataGridView1.Refresh();
        }


        private void exportSelectedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                ICollection<DataGridViewRow> listRow = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    listRow.Add(row);
                }
                ExportToExcelAsync(listRow, filename);
            }
        }

        private void exportAllOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                ICollection<DataGridViewRow> listRow = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    listRow.Add(row);
                }
                ExportToExcelAsync(listRow, filename);
            }
        }



        private async void ExportToExcelAsync(ICollection<DataGridViewRow> rows, string filename)
        {
            metroProgressBar1.Value = 0;
            metroProgressBar1.Visible = true;
            Task<bool> task = Task.Run(() => ExportToExcel(rows, filename));
            bool answer = await task;
            if (answer)
            {
                MessageBox.Show("Order succesfull exported in excel in " + filename, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Exported is not done, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            metroProgressBar1.Visible = false;
        }

        private bool ExportToExcel(ICollection<DataGridViewRow> rows, string filename)
        {
            bool answer = true;
            int rowIndex = 2;
            int total = rows.Count;
            string shablonFile = "Shablon_Export_FEACN.xls";
            try
            {
                File.Copy(shablonFile, filename);
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Workbooks.Open(filename);
                foreach (DataGridViewRow row in rows)
                {
                    for(int i = 1; i < 6; i++)
                    {
                        excelApp.Cells[rowIndex, i] = row.Cells[i].Value;
                    }
                    //excelApp.Cells[rowIndex, 1] = rowIndex - 1;
                    //excelApp.Cells[rowIndex, 2] = row.Cells[1].Value;
                    //excelApp.Cells[rowIndex, 3] = row.Cells[2].Value;
                    //excelApp.Cells[rowIndex, 4] = row.Cells[3].Value;
                    //excelApp.Cells[rowIndex, 5] = row.Cells[4].Value;
                    //excelApp.Cells[rowIndex, 6] = row.Cells[5].Value;
                    rowIndex++;
                    this.Invoke((MethodInvoker)delegate { UpdateProgress(total, rowIndex - 2); });
                }

                workBook.Save();
                workBook.Saved = true;
                workBook.Close();
                excelApp.Quit();
                //GC.Collect();
                //GC.WaitForPendingFinalizers();
                //GC.Collect();
                //GC.WaitForFullGCComplete();
                //GC.WaitForPendingFinalizers();
            }
            catch (Exception) { answer = false; }
            return answer;
        }

        private void UpdateProgress(int total, int current)
        {
            try
            {
                metroProgressBar1.Value = (current * 100) / total;
            }
            catch (Exception) { }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = !filterPanel.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFEACNForm f = new AddFEACNForm();
            f.Show();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            PrintFEACN(searchTB.Text);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFEACNAsync();
        }
    }
}