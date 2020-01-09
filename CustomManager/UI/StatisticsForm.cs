using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class StatisticsForm : Form
    {
        List<StatisticsData> statisticsList;

        public StatisticsForm()
        {
            InitializeComponent();
            statisticsList = new List<StatisticsData>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDataAsync();
        }

        private async void UpdateDataAsync()
        {
            metroProgressSpinner1.Visible = true;
            Task<bool> task = Task.Run(() => UpdateData(dateTimePicker1.Value,dateTimePicker2.Value));
            bool answer = await task;
            if (answer)
            {
                DrawChart();
                statisticsDataBindingSource.DataSource = statisticsList;
                dataGridView1.Refresh();
            }
            metroProgressSpinner1.Visible = false;
        }

        private void DrawChart()
        {
            chart1.Series.Clear();
            foreach(StatisticsData item in statisticsList)
            {
                System.Windows.Forms.DataVisualization.Charting.Series series = chart1.Series.Add(item.HSCode);
                series.ToolTip = item.FEACN_Name;
                series.Points.Add(item.Count);
            }
        }

        private bool UpdateData(DateTime date1,DateTime date2)
        {
            statisticsList.Clear();
            bool answer = false;
            string answerString = MyGlobalClass.DBManager.LoadStatisticsData(ref statisticsList,date1,date2);
            if (answerString.Equals(KEY_VALUES.OK))
            {
                answer = true;
            }
            else
            {
                MessageBox.Show(answerString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                answer = false;
            }
            return answer;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataAsync();
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

        private async void ExportToExcelAsync(ICollection<DataGridViewRow> rows, string filename)
        {
            metroProgressBar1.Value = 0;
            metroProgressBar1.Visible = true;
            Task<bool> task = Task.Run(() => ExportToExcel(rows, filename));
            bool answer = await task;
            if (answer)
            {
                MessageBox.Show("Startistics data succesfull exported in excel in " + filename, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string shablonFile = "Shablon_Export_Statistics.xls";
            try
            {
                File.Copy(shablonFile, filename);
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Workbooks.Open(filename);
                foreach (DataGridViewRow row in rows)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        excelApp.Cells[rowIndex, i] = row.Cells[i-1].Value;
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
    }
}