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
    public partial class OrderProperties : Form
    {
        Order order;
        Product product;
        Region region_sending;
        Region region_origin;
        FEACN feacn;
        double aksizMoney;
        double poshlinaMoney;
        double qqsMoney;
        double summa;
        KursValyuta kurs;



        public OrderProperties(Order _order)
        {
            InitializeComponent();
            this.order = _order;
            product = new CustomManager.Product();
            region_sending = new Region();
            region_origin = new Region();
            feacn = new FEACN();
            CalculatePriceAsync(this.order);
            LoadKursValyutaAsync();
        }

        private async void CalculatePriceAsync(Order order)
        {
            metroProgressSpinner1.Visible = true;
            Task<bool> task = Task.Run(() =>  CalculatePrice(order));
            bool answer = await task;
            if (answer)
            {
                PrintDetails();
            }
            else
            {
                MessageBox.Show("Details not loaded, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            metroProgressSpinner1.Visible = false;
        }


        public bool CalculatePrice(Order order)
        {
            string answerString = string.Empty;

            if (!MyGlobalClass.DBManager.LoadProductbyID(order.product_id, ref product).Equals(KEY_VALUES.OK))
            {
                return false;
            }
            if (!MyGlobalClass.DBManager.LoadRegionbyID(order.region_sending_id, ref region_sending).Equals(KEY_VALUES.OK))
            {
                return false;
            }
            if (!MyGlobalClass.DBManager.LoadRegionbyID(order.region_origin_id, ref region_origin).Equals(KEY_VALUES.OK))
            {
                return false;
            }
            if (!MyGlobalClass.DBManager.LoadFEACNbyID(product.feacn_id, ref feacn).Equals(KEY_VALUES.OK))
            {
                return false;
            }

            aksizMoney = product.Minimum_Cost * feacn.Aksiz_persent / 100;
            poshlinaMoney = product.Minimum_Cost * feacn.Poshlina_persent / 100;
            qqsMoney = (product.Minimum_Cost + aksizMoney + poshlinaMoney) * feacn.QQS_persent / 100;


            if (region_sending.Bonus_persent == 0)
            {
                poshlinaMoney *= 2;
            }

            summa = (product.Minimum_Cost + poshlinaMoney + aksizMoney) * feacn.Poshlina_persent / 100 + product.Minimum_Cost;

            return true;
        }

        private async void LoadKursValyutaAsync()
        {
            Task<bool> task = Task.Run(() => LoadKursValyuta());
            bool answer = await task;
            if (answer)
            {
                if (kurs != null)
                {
                    double koef = Convert.ToDouble(kurs.Rate.Replace('.', ','));
                    faSLB.Text = (aksizMoney * koef).ToString();
                    fpSLB.Text = (poshlinaMoney * koef).ToString();
                    fqSLB.Text = (qqsMoney * koef).ToString();
                    tSLB.Text = (summa * koef).ToString();
                    kursLB.Text = kurs.Info();
                    kursLB.Visible = true;
                }
            }
            //await Task.Run(() => LoadKursValyuta());
        }

        private bool LoadKursValyuta()
        {
            List<KursValyuta> list = new List<KursValyuta>();
            string urlKurs = "http://cbu.uz/uz/arkhiv-kursov-valyut/json/";
            string json= MyGlobalClass.GetResponsible(urlKurs);
            if(MyGlobalClass.TryConvert(json,ref list))
            {
                kurs = list.Where(o => o.Ccy.Equals("USD")).FirstOrDefault();
            }
            return kurs != null;
        }

        private void PrintDetails()
        {
            pnRULB.Text = product.Product_Name_RU;
            pnENLB.Text = product.Product_Name_EN;
            pmLB.Text = product.Model;
            phLB.Text = product.HSCode;
            rsLB.Text = region_sending.Bonus_persent == 0 ? "No (x2)" : "Yes";
            faLB.Text = feacn.Aksiz_persent.ToString() + " %";
            //fcLB.Text = feacn.FEACN_Code;
            fnLB.Text = feacn.FEACN_Name;
            fpLB.Text = feacn.Poshlina_persent.ToString() + " %";
            fqLB.Text = feacn.QQS_persent.ToString() + " %";

            faDLB.Text = aksizMoney.ToString();
            fpDLB.Text = poshlinaMoney.ToString();
            fqDLB.Text = qqsMoney.ToString();
            tDLB.Text = summa.ToString();
        }
    }
}