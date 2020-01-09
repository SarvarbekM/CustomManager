    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomManager
{
    public class Contract
    {
        public int id_contract { get; set; }
        public int customer_id { get; set; }
        public DateTime Give_date { get; set; }
        public DateTime Done_date { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsNotification { get; set; }
        public bool IsAccept { get; set; }
        public string Description { get; set; }
    }
}
