using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomManager
{
    public class Order
    {
        public int id_order { get; set; }
        public int product_id { get; set; }
        public int region_sending_id { get; set; }
        public int region_origin_id { get; set; }
        public double Order_Count { get; set; }
        public int location_id { get; set; }
        public int contract_id { get; set; } 
        
        public Order Clone()
        {
            Order order = new Order();
            order.id_order = this.id_order;
            order.product_id = this.product_id;
            order.region_origin_id = this.region_origin_id;
            order.region_sending_id = this.region_sending_id;
            order.Order_Count = this.Order_Count;
            order.location_id = this.location_id;
            order.contract_id = this.contract_id;
            return order;
        }  
    }
}
