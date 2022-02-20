using Login_MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_MAUI.Interfaces
{
    internal interface IWeather
    {
        Task<List<Weather>> GetWeathers(String token);
    }
}
