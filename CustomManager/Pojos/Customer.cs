using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomManager
{
    public class Customer
    {
        public int id_customer { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int role_id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
