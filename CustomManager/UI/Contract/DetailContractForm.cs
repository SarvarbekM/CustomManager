using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class DetailContractForm : Form
    {
        Contract contract;
        List<Order> orderList;
        public DetailContractForm(Contract c)
        {
            InitializeComponent();
            contract = c;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            LoadOrdersAsync();
        }

        private async void LoadOrdersAsync()
        {
            metroProgressBar1.Visible = true;
            detailsContractBindingSource.DataSource = null;
            dataGridView1.Refresh();
            Task<bool> task = Task.Run(() => LoadOrders());
            bool answer = await task;
            if (answer)
            {
                detailsContractBindingSource.DataSource = DetailsContract.GetDetailsContracts(orderList);
                dataGridView1.Refresh();
            }
            metroProgressBar1.Visible = false;
        }

        private bool LoadOrders()
        {
            bool answer = false;
            List<Order> listOrder = new List<Order>();
            string answerString = MyGlobalClass.DBManager.LoadOrdersByContractID(contract.id_contract, ref listOrder);
            if (answerString.Equals(KEY_VALUES.OK))
            {
                answer = true;
                orderList = listOrder;
            }
            else
            {
                answer = false;
                MessageBox.Show(answerString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return answer;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id_order=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Order order = orderList.Where(o => o.id_order == id_order).FirstOrDefault();
            if (order != null)
            {
                OrderProperties form = new OrderProperties(order);
                form.ShowDialog();
            }
        }
    }


    public class DetailsContract
    {
        public int id_order { get; set; }
        public string Product { get; set; }
        public string Region_sending { get; set; }
        public string Region_origin { get; set; }
        public double Order_count { get; set; }
        public string Price { get; set; }

        public static List<DetailsContract> GetDetailsContracts(List<Order> listOrder)
        {
            List<DetailsContract> detailsList = new List<DetailsContract>();
            DetailsContract dc;
            foreach (Order item in listOrder)
            {
                dc = new DetailsContract();
                dc.id_order = item.id_order;
                Product pr = new CustomManager.Product();
                if (MyGlobalClass.DBManager.LoadProductbyID(item.product_id, ref pr).Equals(KEY_VALUES.OK))
                {
                    dc.Product = pr.Product_Name_RU;
                }
                Region region_sending = new Region();
                if (MyGlobalClass.DBManager.LoadRegionbyID(item.region_sending_id, ref region_sending).Equals(KEY_VALUES.OK))
                {
                    dc.Region_sending = region_sending.Region_Name;
                }
                Region region_origin = new Region();
                if (MyGlobalClass.DBManager.LoadRegionbyID(item.region_origin_id, ref region_origin).Equals(KEY_VALUES.OK))
                {
                    dc.Region_sending = region_origin.Region_Name;
                }
                dc.Order_count = item.Order_Count;
                dc.Price = CalculatePrice(item);
                detailsList.Add(dc);
            }
            return detailsList;
        }

        public static string CalculatePrice(Order order)
        {
            string answerString = string.Empty;
            Product product = new CustomManager.Product();
            Region region_sending = new Region();
            Region region_origin = new Region();
            FEACN feacn = new FEACN();

            if (!MyGlobalClass.DBManager.LoadProductbyID(order.product_id, ref product).Equals(KEY_VALUES.OK))
            {
                answerString = "This is not calculate";
                return answerString;
            }
            if (!MyGlobalClass.DBManager.LoadRegionbyID(order.region_sending_id, ref region_sending).Equals(KEY_VALUES.OK))
            {
                answerString = "This is not calculate";
                return answerString;
            }
            if (!MyGlobalClass.DBManager.LoadRegionbyID(order.region_origin_id, ref region_origin).Equals(KEY_VALUES.OK))
            {
                answerString = "This is not calculate";
                return answerString;
            }
            if (!MyGlobalClass.DBManager.LoadFEACNbyID(product.feacn_id, ref feacn).Equals(KEY_VALUES.OK))
            {
                answerString = "This is not calculate";
                return answerString;
            }

            double aksizMoney = product.Minimum_Cost * feacn.Aksiz_persent / 100;
            double poshlinaMoney = product.Minimum_Cost * feacn.Poshlina_persent / 100;
            double qqsMoney = (product.Minimum_Cost + aksizMoney + poshlinaMoney) * feacn.QQS_persent / 100;


            if (region_sending.Bonus_persent == 0)
            {
                poshlinaMoney *= 2;
            }

            double summa = (product.Minimum_Cost + poshlinaMoney + aksizMoney) * feacn.Poshlina_persent / 100 + product.Minimum_Cost;

            return (summa*order.Order_Count).ToString();


        }
    }
}
