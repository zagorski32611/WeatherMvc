<<<<<<< HEAD
using System;
=======
﻿using System;
>>>>>>> dab116bbd24ce082a6e8d6288fc2eea6f262ab03
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherMvc.Models;

namespace weatherMvc.Interfaces
{
<<<<<<< HEAD
    public interface IWeatherService
    {
        Task<WeatherData> CallDarkSky(double lat, double lng);
        
        void SaveWeatherData(WeatherData weather);
    }
}
=======
    interface IWeatherService
    {
        public Task<WeatherData> CallDarkSky(double lat, double lng);
    }
}
>>>>>>> dab116bbd24ce082a6e8d6288fc2eea6f262ab03
