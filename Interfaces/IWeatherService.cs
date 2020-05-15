using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherMvc.Models;

namespace weatherMvc.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherData> CallDarkSky(double lat, double lng);
        
        void SaveWeatherData(WeatherData weather);
    }
}