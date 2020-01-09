using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager.DatabaseManager
{
    public class DBManager : IDBManager
    {
        public string InsertContract(Contract contract, ref bool answer)
        {
            string answerString = KEY_VALUES.OK;
            string url = string.Format("{0}contract/insert.php?customer_id={1}&give_date={2}&done_date={3}&isdelivered={4}&isnotification={5}&isaccept={6}&description={7}", 
                MyGlobalClass.Host, contract.customer_id, contract.Give_date.ToString("yyyy/MM/dd"),contract.Done_date.ToString("yyyy/MM/dd"),contract.IsDelivered,contract.IsNotification,contract.IsAccept,contract.Description );
            string jsonString = MyGlobalClass.GetResponsible(url);
            if (string.IsNullOrEmpty(jsonString))
            {
                answerString = "You is offline";
            }
            else if (jsonString.Equals("1"))
            {
                answer = true;
            }
            else if (jsonString.Equals("0"))
            {
                answer = false;
            }
            return answerString;
        }

        internal string LoadStatisticsData(ref List<StatisticsData> statisticsList,DateTime date1,DateTime date2)
        {
            //magdis.uz/contract/readfororder.php?date1=2018/12/08&date2=2018/12/14
            string answer = KEY_VALUES.OK;
            string url = string.Format("{0}contract/readfororder.php?date1={1}&date2={2}", MyGlobalClass.Host, date1.ToString("yyyy/MM/dd"), date2.ToString("yyyy/MM/dd"));
            string jsonString = MyGlobalClass.GetResponsible(url);
            List<StatisticsData> f = new List<StatisticsData>();
            if (MyGlobalClass.TryConvert(jsonString, ref f))
            {
                statisticsList = f;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "Statistics data is not loaded, please try again";
                }
            }
            return answer;
        }

        public string InsertFEACN(FEACN feacn,ref bool answer)
        {
            string answerString = KEY_VALUES.OK;
            string url = string.Format("{0}feacn/insert.php?code={1}&name={2}&aksiz={3}&poshlina={4}&qqs={5}", MyGlobalClass.Host, feacn.FEACN_Code, feacn.FEACN_Name, feacn.Aksiz_persent, feacn.Poshlina_persent, feacn.QQS_persent);
            string jsonString = MyGlobalClass.GetResponsible(url);
            if (string.IsNullOrEmpty(jsonString))
            {
                answerString = "You is offline";
            }
            else if (jsonString.Equals("1"))
            {
                answer = true;
            }
            else if (jsonString.Equals("0"))
            {
                answer = false;
            }
            return answerString;
        }

        public string InsertOrder(Order order, ref bool answer)
        {
            string answerString = KEY_VALUES.OK;
            string url = string.Format("{0}order/insert.php?product_id={1}&sending_id={2}&origin_id={3}&order_count={4}&location_id={5}&contract_id={6}", MyGlobalClass.Host, order.product_id, order.region_sending_id, order.region_origin_id, order.Order_Count, order.location_id,order.contract_id);
            string jsonString = MyGlobalClass.GetResponsible(url);
            if (string.IsNullOrEmpty(jsonString))
            {
                answerString = "You is offline";
            }
            else if (jsonString.Equals("1"))
            {
                answer = true;
            }
            else if (jsonString.Equals("0"))
            {
                answer = false;
            }
            return answerString;
        }

        public string InsertProduct(Product product, ref bool answer)
        {
            string answerString = KEY_VALUES.OK;
            string url = string.Format("{0}product/insert.php?code={1}&hscode={2}&name_ru={3}&name_en={4}&min_cost={5}&shop_cost={6}&type_money_id={7}&measure_count={8}&type_measure_id={9}&weight={10}&model={11}&feacn_id={12}", MyGlobalClass.Host, product.Product_Code, product.HSCode, product.Product_Name_RU, product.Product_Name_EN, product.Minimum_Cost.ToString().Replace(",", "."), product.Shop_Cost.ToString().Replace(",", "."), product.type_money_id, product.Measure_Count.ToString().Replace(",", "."), product.type_measure_id, product.Weight.ToString().Replace(",", "."), product.Model, product.feacn_id);            
            string jsonString = MyGlobalClass.GetResponsible(url);
            if (string.IsNullOrEmpty(jsonString))
            {
                answerString = "You is offline";
            }
            else if (jsonString.Equals("1"))
            {
                answer = true;
            }
            else if (jsonString.Equals("0"))
            {
                answer = false;
            }
            return answerString;
        }

        public string IsHaveLogin(string login, ref bool answer)
        {
            string answerString = KEY_VALUES.OK;
            string url = string.Format("{0}customer/readbylogin.php?log={1}", MyGlobalClass.Host, login);
            string jsonString = MyGlobalClass.GetResponsible(url);

            if (string.IsNullOrEmpty(jsonString))
            {
                answerString = "You is offline";
            }
            else if (jsonString.Equals("1"))
            {
                answer = true;
            }
            else if (jsonString.Equals("0"))
            {
                answer = false;
            }
            return answerString;
        }

        public string LoadFEACNbyID(int id, ref FEACN feacn)
        {
            string answer = KEY_VALUES.OK;
            string url = string.Format("{0}feacn/readbyid.php?id={1}", MyGlobalClass.Host, id);
            string jsonString = MyGlobalClass.GetResponsible(url);
            FEACN f = new FEACN();
            if (MyGlobalClass.TryConvert(jsonString, ref f))
            {
                feacn = f;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "FEACN is not loaded, please try again";
                }
            }
            return answer;
        }

        public string LoadContractByMaxid(ref Contract contract)
        {
            string answer = KEY_VALUES.OK;
            string url = MyGlobalClass.Host + "contract/readmaxid.php";
            string jsonString = MyGlobalClass.GetResponsible(url);
            Contract c = new Contract();
            if (MyGlobalClass.TryConvert(jsonString, ref c))
            {
                contract = c;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "Contract is not loaded, please try again";
                }
            }
            return answer;
        }

        public string LoadContracts(ref List<Contract> contractList)
        {
            string answer = KEY_VALUES.OK;
            string url = MyGlobalClass.Host + "contract/read.php";
            string jsonString = MyGlobalClass.GetResponsible(url);
            List<Contract> list = new List<Contract>();
            if (MyGlobalClass.TryConvert(jsonString, ref list))
            {
                contractList = list;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "Contracts is not loaded, please try again";
                }
            }
            return answer;
        }

        public string LoadLocationbyID(int id, ref Location location)
        {
            string answer = KEY_VALUES.OK;
            string url = string.Format("{0}location/readonce.php?id={1}", MyGlobalClass.Host, id);
            string jsonString = MyGlobalClass.GetResponsible(url);
            Location loc = new Location();
            if (MyGlobalClass.TryConvert(jsonString, ref loc))
            {
                location = loc;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "Location is not loaded, please try again";
                }
            }
            return answer;
        }

        public string LoadOrdersByContractID(int contractID, ref List<Order> orderList)
        {
            string answer = KEY_VALUES.OK;
            string url = string.Format("{0}order/readbycontractid.php?contractID={1}", MyGlobalClass.Host, contractID);
            string jsonString = MyGlobalClass.GetResponsible(url);
            List<Order> orL = new List<Order>();
            if (MyGlobalClass.TryConvert(jsonString, ref orL))
            {
                orderList = orL;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "Orders is not loaded, please try again";
                }
            }
            return answer;
        }

        public string LoadProductbyID(int id, ref Product product)
        {
            string answer = KEY_VALUES.OK;
            string url = string.Format("{0}product/readonce.php?id={1}", MyGlobalClass.Host, id);
            string jsonString = MyGlobalClass.GetResponsible(url);
            Product pro = new Product();
            if (MyGlobalClass.TryConvert(jsonString, ref pro))
            {
                product = pro;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = string.Format("Product id={0} is not loaded, please try again", id);
                }
            }
            return answer;
        }

        public string LoadProducts(ref List<Product> productList)
        {
            string answer = KEY_VALUES.OK;
            string url = MyGlobalClass.Host + "product/read.php";
            string jsonString = MyGlobalClass.GetResponsible(url);
            List<Product> list = new List<Product>();
            if (MyGlobalClass.TryConvert(jsonString, ref list))
            {
                productList = list;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "Products is not loaded, please try again";
                }
            }
            return answer;
        }

        public string LoadRegionbyID(int id, ref Region region)
        {
            string answer = KEY_VALUES.OK;
            string url = string.Format("{0}region/readbyid.php?id={1}", MyGlobalClass.Host, id);
            string jsonString = MyGlobalClass.GetResponsible(url);
            Region reg = new Region();
            if (MyGlobalClass.TryConvert(jsonString, ref reg))
            {
                region = reg;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = string.Format("Region id={0} is not loaded, please try again", id);
                }
            }
            return answer;
        }

        public string LoadRegions(ref List<Region> regionList)
        {
            string answer = KEY_VALUES.OK;
            string url = MyGlobalClass.Host + "region/read.php";
            string jsonString = MyGlobalClass.GetResponsible(url);
            List<Region> list = new List<Region>();
            if (MyGlobalClass.TryConvert(jsonString, ref list))
            {
                regionList = list;
            }
            else
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    answer = "You is offline";
                }
                else
                {
                    answer = "Regions is not loaded, please try again";
                }
            }
            return answer;
        }

        public string Register(Customer customer)
        {
            string answer = KEY_VALUES.OK;
            string url = MyGlobalClass.Host + "customer/register.php?name=" + customer.Customer_Name
                + "&surname=" + customer.Customer_Surname
                + "&login=" + customer.Login
                + "&password=" + customer.Password
                + "&email=" + customer.Email
                + "&phone=" + customer.Phone
                + "&role_id=" + customer.role_id;
            string jsonString = MyGlobalClass.GetResponsible(url);
            if (string.IsNullOrEmpty(jsonString))
            {
                answer = "You is offline";
            }
            else if (!jsonString.Equals("1"))
            {
                answer = "Error: " + jsonString;
            }
            return answer;
        }

        public string SignIn(string login, string password)
        {
            string answer = KEY_VALUES.OK;
            string url = MyGlobalClass.Host + "customer/signin.php?log=" + login + "&pass=" + password;

            string jsonString = MyGlobalClass.GetResponsible(url);

            if (jsonString.Equals("0") || string.IsNullOrEmpty(jsonString))
            {
                if (jsonString.Equals("0"))
                {
                    answer = "Login or password is wrong";
                }
                else
                {
                    answer = "You is offline";
                }
                return answer;
            }

            Customer c = new Customer();
            if (MyGlobalClass.TryConvert(jsonString, ref c))
            {
                MyGlobalClass.Customer = c;
            }
            else
            {
                answer = "Customer not loaded, please try again";
                return answer;
            }
            return answer;
        }

    }
}
