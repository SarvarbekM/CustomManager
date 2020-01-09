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
    public partial class ProductForm : Form
    {

        List<Product> allProducts;
        List<Product> filteredProducts;
        public ProductForm()
        {
            InitializeComponent();
            allProducts = new List<Product>();
            filteredProducts = new List<Product>();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            loadProductsAsync();
        }

        private async void loadProductsAsync()
        {
            metroProgressSpinner1.Visible = true;
            allProducts.Clear();
            Task<bool> task = Task.Run(() => loadProduct());
            bool answer = await task;
            if (answer)
            {
                PrintProducts();
            }
            else
            {
                MessageBox.Show("Products not loaded, please close the form and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            metroProgressSpinner1.Visible = false;
        }

        private bool loadProduct()
        {
            string url = MyGlobalClass.Host + "product/read.php";
            string json = MyGlobalClass.GetResponsible(url);
            return MyGlobalClass.TryConvert(json, ref allProducts); ;
        }

        private void PrintProducts()
        {
            productBindingSource.DataSource = null;
            dataGridView1.Refresh();
            filteredProducts.Clear();
            if (!string.IsNullOrEmpty(searchTB.Text))
            {
                foreach (Product product in allProducts)
                {
                    if (product.HSCode.Contains(searchTB.Text) || product.Model.Contains(searchTB.Text) || product.Product_Code.Contains(searchTB.Text) ||
                        product.Product_Name_EN.Contains(searchTB.Text) || product.Product_Name_RU.Contains(searchTB.Text))
                    {
                        filteredProducts.Add(product);
                    }
                }
            }
            else
            {
                foreach (Product product in allProducts)
                {
                    filteredProducts.Add(product);
                }
            }
            productBindingSource.DataSource = filteredProducts;
            dataGridView1.Refresh();
        }

        private void exportSelectedProductsToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Products succesfull exported in excel in " + filename, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Products is not exported in excel, please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            metroProgressBar1.Visible = false;
        }
        private bool ExportToExcel(ICollection<DataGridViewRow> rows, string filename)
        {
            bool answer = true;
            int rowIndex = 2;
            int total = rows.Count;
            string shablonFile = "Shablon_Export_Product.xls";
            try
            {
                File.Copy(shablonFile, filename);
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Workbooks.Open(filename);

                foreach (DataGridViewRow row in rows)
                {
                    for (int i = 1; i < 9; i++)
                    {
                        excelApp.Cells[rowIndex, i] = row.Cells[i].Value;
                    }
                    //excelApp.Cells[rowIndex, 4] = row.Cells[4].Value;
                    //excelApp.Cells[rowIndex, 1] = row.Cells[1].Value;
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

        private void exportAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void giveOrderForCurrentProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int id_product = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                Product p = filteredProducts.Where(i => i.id_product == id_product).FirstOrDefault();
                if (p != null)
                {
                    //AddOrderForm f = new AddOrderForm();
                    //f.ShowDialog();
                }
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            filterPanel.Visible = !filterPanel.Visible;
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            PrintProducts();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadProductsAsync();
        }
    }
}
