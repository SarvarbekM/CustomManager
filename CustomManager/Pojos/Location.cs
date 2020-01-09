using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomManager
{
    public class Location
    {
        public int id_location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }


        public string Info()
        {
            return "id=" + this.id_location + "\nLat=" + Latitude + "\nLon=" + Longitude;
        }
    }
}
