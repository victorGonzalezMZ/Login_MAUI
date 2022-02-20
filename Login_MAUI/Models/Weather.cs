using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_MAUI.Models
{
    public class Weather
    {
        public DateTime date { get; set; }

        public int temperatureC { get; set; }

        public int temperatureF { get; set; }

        public string summary { get; set; }

        public static implicit operator List<object>(Weather v)
        {
            throw new NotImplementedException();
        }
    }
}
