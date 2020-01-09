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
    public partial class ContractForm : Form
    {
        List<Contract> listContract;

        public ContractForm()
        {
            InitializeComponent();
            listContract = new List<Contract>();            
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            LoadContractAsync();
        }

        private async void LoadContractAsync()
        {
            metroProgressSpinner1.Visible = true;
            contractBindingSource.Clear();
            dataGridView1.Refresh();
            Task<bool> task = Task.Run(() => LoadContract());
            bool answer = await task;
            if (answer)
            {
                contractBindingSource.DataSource = listContract;
                dataGridView1.Refresh();
            }
            else
            {
                //MessageBox.Show("Contracts not loaded, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            metroProgressSpinner1.Visible = false;
        }

        private bool LoadContract()
        {
            listContract.Clear();
            bool answer = false;
            string answerString = MyGlobalClass.DBManager.LoadContracts(ref listContract);
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

        //private bool ExportToExcel(ICollection<DataGridViewRow> rows,string filename)
        //{
        //    bool answer = true;
        //    int rowIndex = 3;
        //    int total = rows.Count;
        //    string shablonFile = "Shablon_Export_Order.xls";
        //    try
        //    {
        //        File.Copy(shablonFile, filename);
        //        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
        //        Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Workbooks.Open(filename);
        //        foreach (DataGridViewRow row in rows)
        //        {
        //            int id_order = Convert.ToInt32(row.Cells[0].Value);
        //            Order or = listOrder.Where(o => o.id_order == id_order).FirstOrDefault();
        //            if(or!=null)
        //            {                        
        //                string url = MyGlobalClass.Host + "product/readonce.php?id=" + or.product_id.ToString();
        //                string json = MyGlobalClass.GetResponsible(url);
        //                Product pr = new Product();
        //                if(MyGlobalClass.TryConvert(json,ref pr))
        //                {
        //                    ProductView pv = Product.GetProductView(pr);
        //                    excelApp.Cells[rowIndex, 1] = pv.Code;
        //                    excelApp.Cells[rowIndex, 2] = pv.HSCode;
        //                    excelApp.Cells[rowIndex, 3] = pv.Name_RU;
        //                    excelApp.Cells[rowIndex, 4] = pv.Name_EN;
        //                    excelApp.Cells[rowIndex, 5] = pv.Count;
        //                    excelApp.Cells[rowIndex, 6] = pv.Cost;
        //                    excelApp.Cells[rowIndex, 7] = pv.Model;
        //                }
        //            }

        //            excelApp.Cells[rowIndex, 8] = row.Cells[2].Value;
        //            excelApp.Cells[rowIndex, 9] = row.Cells[3].Value;
        //            excelApp.Cells[rowIndex, 10] = row.Cells[4].Value;
        //            excelApp.Cells[rowIndex, 11] = row.Cells[5].Value;
        //            excelApp.Cells[rowIndex, 12] = row.Cells[6].Value;
        //            excelApp.Cells[rowIndex, 13] = row.Cells[7].Value;
        //            excelApp.Cells[rowIndex, 14] = row.Cells[8].Value;
        //            rowIndex++;
        //            this.Invoke((MethodInvoker)delegate { UpdateProgress(total, rowIndex - 3); });
        //        }

        //        workBook.Save();
        //        workBook.Saved = true;
        //        workBook.Close();
        //        excelApp.Quit();
        //        GC.Collect();
        //        GC.WaitForPendingFinalizers();
        //        GC.Collect();
        //        GC.WaitForFullGCComplete();
        //        GC.WaitForPendingFinalizers();
        //    }
        //    catch (Exception) { answer = false; }
        //    return answer;
        //}

        //private void UpdateProgress(int total,int current)
        //{
        //    try
        //    {
        //        metroProgressBar1.Value = (current * 100) / total;
        //    }
        //    catch (Exception) { }
        //}

        private void addButton_Click(object sender, EventArgs e)
        {
            AddContractForm f = new AddContractForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadContractAsync();
            }
        }

        private void detailsProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contractID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);            
            Contract contract= listContract.Where(o => o.id_contract == contractID).FirstOrDefault();
            DetailContractForm f = new DetailContractForm(contract);
            f.ShowDialog();
        }
    }
}