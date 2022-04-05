using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    internal class WeatherMethods
    {

        public class coord
        {
            public double lon {get; set;}
            public double lat { get; set;}

        }

        public class weather
        {
            string main { get; set; }
            string description { get; set; }
            string icon { get; set; }
        }

        public class main
        {
            double temp { get; set; }
            double pressure { get; set; }
            double humidity { get; set; }

        }

        public class wind
        {
            double speed { get; set; }
        }

        public class system
        {
            long sunrise { get; set; }
            long sunset { get; set; }

        }

        public class report
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public system system { get; set; }
        }
    }
}
