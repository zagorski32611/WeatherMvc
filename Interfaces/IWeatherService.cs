using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherMvc.Models;

namespace weatherMvc.Interfaces
{
    interface IWeatherService
    {
        public Task<WeatherData> CallDarkSky(double lat, double lng);
    }
}
