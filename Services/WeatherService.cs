using System;
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
        {
            WeatherData weather_data = new WeatherData();
            HttpClient httpclient = new HttpClient();

            string weather_uri = $"https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/{lat},{lng}?exclude=minutely,hourly";
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

        public async void SaveWeatherData(WeatherData weatherData)
        {
            try
            {
                _context.Add(weatherData);
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine("${e}");
            }

        }
    }
}
