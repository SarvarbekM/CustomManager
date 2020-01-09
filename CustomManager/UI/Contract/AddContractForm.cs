using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class AddContractForm : Form
    {
        List<Order> orderList;

        public AddContractForm()
        {
            InitializeComponent();
            orderList = new List<Order>();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            dateTP.Value = DateTime.Now;
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddOrderForm f = new AddOrderForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                orderList.Add(GlobalVariables.Order.Clone());
                addContractViewBindingSource.DataSource = AddContractView.GetViewList(orderList);
                dataGridView1.Refresh();
            }
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriptionTB.Text))
            {
                errorProvider1.SetError(descriptionTB, "Description is empty");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (orderList.Count != 0)
            {
                Contract contract = new Contract() { customer_id = MyGlobalClass.Customer.id_customer, Description = descriptionTB.Text, Done_date = DateTime.Now, Give_date = dateTP.Value, IsAccept = false, IsDelivered = false, IsNotification = true };
                AddContractAsync(contract);
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private async void AddContractAsync(Contract contract)
        {
            metroProgressSpinner1.Visible = true;

            Task<bool> task = Task.Run(() => AddContract(contract));
            bool answer = await task;
            if (!answer)
            {
                this.DialogResult = DialogResult.None;
            }
            metroProgressSpinner1.Visible = false;
        }

        private bool AddContract(Contract contract)
        {
            bool answer = false;
            string answerString = MyGlobalClass.DBManager.InsertContract(contract,ref answer);
            if (answerString.Equals(KEY_VALUES.OK))
            {
                answer = AddOrders();
                if (answer)
                {
                    MessageBox.Show("Contract is succesfull inserted","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Contract is not inserted, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(answerString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return answer;
        }

        private bool AddOrders()
        {   
            bool answer = false;
            Contract contract = new Contract();
            if(MyGlobalClass.DBManager.LoadContractByMaxid(ref contract).Equals(KEY_VALUES.OK))
            {
                int count = 0;
                foreach (Order item in orderList)
                {
                    item.contract_id = contract.id_contract;
                    if (MyGlobalClass.DBManager.InsertOrder(item, ref answer).Equals(KEY_VALUES.OK))
                    {
                        if (answer) count++;
                    }
                }                
                return count == orderList.Count;
            }
            else
            {
                return answer;
            }
        }

        private void descriptionTB_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, string.Empty);
        }
    }
    public class AddContractView
    {
        public string Product { get; set; }
        public string Region_Sending { get; set; }
        public string Region_Origin { get; set; }
        public double Order_Count { get; set; }
        public string Location { get; set; }
        public int product_id { get; set;}
        public int location_id { get; set; }

        public static List<AddContractView> GetViewList(List<Order> listOrder)
        {
            List<AddContractView> list = new List<AddContractView>();
            string url = string.Empty;
            foreach(Order item in listOrder)
            {
                AddContractView view = new AddContractView();

                Product product = new CustomManager.Product();
                string answer = MyGlobalClass.DBManager.LoadProductbyID(item.product_id, ref product);
                if(!answer.Equals(KEY_VALUES.OK))
                {
                    MessageBox.Show(answer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    view.Product = product.Product_Name_RU;
                    view.product_id = item.product_id;
                }

                Region region_sending = new Region();
                answer = MyGlobalClass.DBManager.LoadRegionbyID(item.region_sending_id, ref region_sending);
                if (!answer.Equals(KEY_VALUES.OK))
                {
                    MessageBox.Show(answer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    view.Region_Sending = region_sending.Region_Name;
                }
                

                Region region_origin = new Region();
                answer = MyGlobalClass.DBManager.LoadRegionbyID(item.region_origin_id, ref region_origin);
                if (!answer.Equals(KEY_VALUES.OK))
                {
                    MessageBox.Show(answer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    view.Region_Origin = region_origin.Region_Name;
                }
                
                view.Order_Count = item.Order_Count;

                Location location = new CustomManager.Location();
                answer = MyGlobalClass.DBManager.LoadLocationbyID(item.location_id, ref location);
                if (!answer.Equals(KEY_VALUES.OK))
                {
                    //MessageBox.Show(answer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    view.Location = string.Format("Lat={0}; Lon={1}", location.Latitude, location.Longitude);
                    view.location_id = item.location_id;
                }

                list.Add(view);
            }

            return list;
        }
    }
}
