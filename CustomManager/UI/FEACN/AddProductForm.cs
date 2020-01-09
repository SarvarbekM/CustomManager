using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel file(*.xls)|*.xls;*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                LoadProductfromFileAsync(filename);
            }
        }

        private async void LoadProductfromFileAsync(string filename)
        {
            try
            {
                Task<bool> task = Task.Run(() => LoadProductfromFile(filename));
                bool answer = await task;
                if (!answer)
                {
                    MessageBox.Show("Products is not inserted in database, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}",ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LoadProductfromFile(string filename)
        {

            bool answer = true;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filename);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            if (colCount != 12)
            {
                MessageBox.Show(filename + " Excel file not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int allproductCount = rowCount - 1;
            int insertProductCount = 0;
            var window = MessageBox.Show(string.Format("Find {0} products, Are sure to you want add database all ?", allproductCount), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (window == DialogResult.Yes)
            {
                answer = true;
                Product product = null;
                
                for (int i = 2; i <= rowCount; i++)
                {
                    product = new Product();                    

                    if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.Product_Code= xlRange.Cells[i, 1].Value2.ToString();
                    }
                    if (xlRange.Cells[i, 2] != null && xlRange.Cells[i, 2].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.HSCode = xlRange.Cells[i, 2].Value2.ToString();
                    }
                    if (xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.Product_Name_RU = xlRange.Cells[i, 3].Value2.ToString();
                    }
                    if (xlRange.Cells[i, 4] != null && xlRange.Cells[i, 4].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.Product_Name_EN = xlRange.Cells[i, 4].Value2.ToString();
                    }
                    if (xlRange.Cells[i, 5] != null && xlRange.Cells[i, 5].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        string numberString = xlRange.Cells[i, 5].Value2.ToString().Replace(",",".");
                        product.Minimum_Cost = Convert.ToDouble(xlRange.Cells[i, 5].Value2.ToString());
                        //product.Minimum_Cost = Convert.ToDouble(numberString);
                    }
                    if (xlRange.Cells[i, 6] != null && xlRange.Cells[i, 6].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.Shop_Cost = double.Parse(xlRange.Cells[i, 6].Value2.ToString());
                    }
                    if (xlRange.Cells[i, 7] != null && xlRange.Cells[i, 7].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.type_money_id = int.Parse(xlRange.Cells[i, 7].Value2.ToString());
                    }
                    if (xlRange.Cells[i, 8] != null && xlRange.Cells[i, 8].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.Measure_Count = double.Parse(xlRange.Cells[i, 8].Value2.ToString());
                    }
                    if (xlRange.Cells[i, 9] != null && xlRange.Cells[i, 9].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.type_measure_id = int.Parse(xlRange.Cells[i, 9].Value2.ToString());
                    }
                    if (xlRange.Cells[i, 10] != null && xlRange.Cells[i, 10].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.Weight = double.Parse(xlRange.Cells[i, 10].Value2.ToString());
                    }
                    if (xlRange.Cells[i, 11] != null && xlRange.Cells[i, 11].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.Model = xlRange.Cells[i, 11].Value2.ToString();
                    }
                    if (xlRange.Cells[i, 12] != null && xlRange.Cells[i, 12].Value2 != null)
                    {
                        //MessageBox.Show(xlRange.Cells[i, 1].Value2.ToString());
                        product.feacn_id = int.Parse(xlRange.Cells[i, 12].Value2.ToString());
                    }

                    bool result = false;
                    string resultString = MyGlobalClass.DBManager.InsertProduct(product, ref result);
                    if (resultString.Equals(KEY_VALUES.OK))
                    {
                        if(result) insertProductCount++;
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Error: {0}", resultString), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            else
            {
                answer = false;
            }

            MessageBox.Show(string.Format("All product count is {0}, Insert Product count is {1}", allproductCount, insertProductCount), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //cleanup  
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:  
            //  never use two dots, all COM objects must be referenced and released individually  
            //  ex: [somthing].[something].[something] is bad  

            //release com objects to fully kill excel process from running in the background  
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet);

            //close and release  
            xlWorkbook.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);

            //quit and release  
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            return answer;
        }
    }
}