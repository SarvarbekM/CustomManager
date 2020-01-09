using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class AddOrderForm : Form
    {
        List<Product> productList;
        List<Region> regionList;

        public AddOrderForm()
        {
            InitializeComponent();
            productList = new List<Product>();
            regionList = new List<CustomManager.Region>();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            LoadAllDataAsync();
        }

        private async void LoadAllDataAsync()
        {
            metroProgressSpinner1.Visible = true;
            Task<bool> task = Task.Run(() =>  LoadAllData());
            bool answer = await task;
            if (answer)
            {
                productBindingSource.DataSource = productList;
                sendingRegionBS.DataSource = regionList;
                originRegionBS.DataSource = regionList;
                dataGridView1.Refresh();
                sendingCB.Refresh();
                originCB.Refresh();
            }
            metroProgressSpinner1.Visible = false;
        }

        private bool LoadAllData()
        {
            string answerProduct = LoadProducts();
            string answerRegion = LoadRegions();
            return answerProduct.Equals(KEY_VALUES.OK) && answerRegion.Equals(KEY_VALUES.OK);
        }

        private string LoadProducts()
        {
            return MyGlobalClass.DBManager.LoadProducts(ref productList);
        }

        private string LoadRegions()
        {
            return MyGlobalClass.DBManager.LoadRegions(ref regionList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int origin_id = 0;
            int sending_id = 0;
            double order_count = 0;
            if (originCB.SelectedValue != null)
            {
                origin_id = (int)originCB.SelectedValue;
            }
            else
            {
                errorProvider1.SetError(originCB, "Region origin is not selected");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (sendingCB.SelectedValue != null)
            {
                sending_id = (int)sendingCB.SelectedValue;
            }
            else
            {
                errorProvider1.SetError(sendingCB, "Region sending is not selected");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (numericUpDown1.Value != 0)
            {
                order_count = Convert.ToDouble(numericUpDown1.Value);
            }
            else
            {
                errorProvider1.SetError(numericUpDown1, "Order count is not entered");
                this.DialogResult = DialogResult.None;
                return;
            }

            Order order = new Order();
            order.Order_Count = order_count;
            order.region_origin_id = origin_id;
            order.region_sending_id = sending_id;
            order.product_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            order.location_id = 1;

            GlobalVariables.Order = order.Clone();
        }

        private void sendingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }
    }
}