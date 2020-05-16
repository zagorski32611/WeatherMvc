using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherMvc.Models;
using weatherMvc.Interfaces;
using System.Net.Http;
using Newtonsoft.Json;
using weatherMvc.Data;

namespace weatherMvc.Services
{
    public class LocationService : ILocationService
    {
        private readonly WeatherMvcDbContext _context;

        public LocationService(WeatherMvcDbContext context)
        {
            _context = context;
        }

        public async Task<LocationData> LocationSearch(string searchAddress)
        {
            LocationData location = new LocationData();
            HttpClient httpClient = new HttpClient();

            // build request string:
            string encodedAddress = System.Net.WebUtility.HtmlEncode(searchAddress);


            string baseUrl = "https://maps.googleapis.com/maps/api/geocode/json?";
            string cityLookup = $"address={searchAddress}&region=us&key=AIzaSyAvHBuqmay0q_5_k3YKBm0irl4b2FobR7s";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl + cityLookup}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                LocationData deserializedLocation = JsonConvert.DeserializeObject<LocationData>(responseBody);

                location = deserializedLocation;

                return location;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot reach google because {e}");
                return location;
            }
            finally
            {
                SaveLocationData(location);
            }
        }

        public async void SaveLocationData(LocationData location)
        {
            try
            {
                await _context.SaveChangesAsync();

            }
            catch(Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }
        // Internal Requests: 4 hours
        // Incidents: 2 hours
        /*
         * 1 look at old tickets - EXTREMELY IMPORTANT
         * 2 error log - first recreate then error log
         * 
         */
    }
}