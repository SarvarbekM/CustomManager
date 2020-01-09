using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomManager
{
    public class Product
    {
        public int id_product { get; set; }
        public string Product_Code { get; set; }
        public string HSCode { get; set; }
        public string Product_Name_RU { get; set; }
        public string Product_Name_EN { get; set; }
        public double Minimum_Cost { get; set; }
        public double Shop_Cost { get; set; }
        public int type_money_id { get; set; }
        public double Measure_Count { get; set; }
        public int type_measure_id { get; set; }
        public double Weight { get; set; }
        public string Model { get; set; }
        public int feacn_id { get; set; }

        public string Info()
        {
            return "id_product=" + id_product + "\n" +
                "Product_Code=" + Product_Code + "\n" +
                "HSCode=" + HSCode + "\n" +
                "Product_Name_RU=" + Product_Name_RU + "\n" +
                "Product_Name_EN=" + Product_Name_EN + "\n" +
                "type_measure_id=" + type_measure_id + "\n" +
                "Measure_Count=" + Measure_Count + "\n" +
                "type_money_id=" + type_money_id + "\n" +
                "Weight=" + Weight + "\n";
        }
    }
}
