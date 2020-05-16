<<<<<<< HEAD
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using weatherMvc.Data;
using weatherMvc.Models;
using weatherMvc.Interfaces;

namespace weatherMvc.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly WeatherMvcDbContext _context;

        public WeatherService(WeatherMvcDbContext context)
        {
            _context = context;
        }

        public async Task<WeatherData> CallDarkSky(double longitude, double latitude)
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using weatherMvc.Models;
using Newtonsoft.Json;
using weatherMvc.Data;

namespace weatherMvc.Services
{
    public class WeatherService
    {
        private readonly WeatherMvcDbContext _context;

        public async Task<WeatherData> CallDarkSky(double lat, double lng)
>>>>>>> dab116bbd24ce082a6e8d6288fc2eea6f262ab03
        {
            WeatherData weather_data = new WeatherData();
            HttpClient httpclient = new HttpClient();

<<<<<<< HEAD
            string weather_uri = $"https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/{latitude},{longitude}?exclude=minutely,hourly";
=======
            string weather_uri = $"https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/{lat},{lng}?exclude=minutely,hourly";
>>>>>>> dab116bbd24ce082a6e8d6288fc2eea6f262ab03
            // 41.443423,-81.775168

            try
            {
                HttpResponseMessage response = await httpclient.GetAsync($"{weather_uri}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                WeatherData deserializedWeather = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                weather_data = deserializedWeather;

                return weather_data;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Reach Dark Sky...");
                Console.WriteLine($"Reason: {e}");
                return weather_data;
            }
            finally
            {
                SaveWeatherData(weather_data);
            }
        }

<<<<<<< HEAD
        public async void SaveWeatherData(WeatherData weather)
        {
            try
            {
                _context.Add(weather);
=======
        public async void SaveWeatherData(WeatherData weatherData)
        {
            try
            {
                _context.Add(weatherData);
>>>>>>> dab116bbd24ce082a6e8d6288fc2eea6f262ab03
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
<<<<<<< HEAD
                Console.WriteLine($"{e}");
            }
        }

    }
}
=======
                Console.WriteLine("${e}");
            }

        }
    }
}
>>>>>>> dab116bbd24ce082a6e8d6288fc2eea6f262ab03
