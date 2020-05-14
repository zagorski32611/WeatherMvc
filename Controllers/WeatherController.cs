using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using weatherMvc.Data;
using weatherMvc.Models;
using weatherMvc.Services;
using weatherMvc.Interfaces;
using System.Text.RegularExpressions;


namespace weatherMvc.Controllers
{
    public partial class WeatherController : Controller
    {
        private readonly WeatherMvcDbContext _context;

        IRequestResponse _rAndr;

        public WeatherController(WeatherMvcDbContext context, IRequestResponse rAndr)
        {
            _context = context;
            _rAndr = rAndr;
        }


        public IActionResult setLocation()
        {
            var ViewModel = new LocationData();
            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult setLocation(LocationData model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "weather", new { longitude = model.searchLng, latitude = model.searchLng, rawAddress = model.searchAddress });
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Index(double longitude, double latitude, string rawAddress = "")
        {
            ViewData["weatherData"] = new WeatherData();
            ViewData["location"] = new LocationData();

            if (rawAddress.Length == 0)
            {
                // reverse geocode method
                // then geocode = GoogleGeoCode_Reverse(lat,long);
                WeatherData weather = CallDarkSky(longitude, latitude).Result;
                ViewData["weatherData"] = weather;
                return View();
            }
            else
            {
                LocationData geocode = GetLocationFromGoogle(rawAddress).Result;
                ViewData["location"] = geocode;

                if (geocode is null)
                {
                    return View("error");
                }
                else
                {
                    double result_lat = geocode.results[0].geometry.location.lat;
                    double result_lng = geocode.results[0].geometry.location.lng;

                    WeatherData weather = CallDarkSky(result_lng, result_lat).Result;

                    ViewData["weatherData"] = weather;

                    return View();
                }
            }
        }

        public async Task<WeatherData> CallDarkSky(double longitude, double latitude)
        {
            WeatherData weather_data = new WeatherData();
            HttpClient httpclient = new HttpClient();

            string weather_uri = $"https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/{latitude},{longitude}?exclude=minutely,hourly";               //{41.443423},{-81.775168}

            try
            {
                HttpResponseMessage response = await httpclient.GetAsync($"{weather_uri}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                WeatherData deserializedWeather = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                weather_data = deserializedWeather;

                requestAndResponseVerification requestAndResponseVerification = _rAndr.takeRequestResponseSnapshot(request_string: response.RequestMessage.RequestUri.ToString(), response_string: responseBody.ToString(), time_stamp: DateTime.Now,
                                                    target_uri: httpclient.BaseAddress.ToString(), http_status_code: response.StatusCode.ToString());
                if(requestAndResponseVerification.save_success_flag == true)
                {
                    Console.WriteLine("it worked!");
                }

                return weather_data;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Reach Dark Sky...");
                Console.WriteLine($"Reason: {e}");
                return weather_data;
            }
        }

        public async Task<LocationData> GetLocationFromGoogle(string address)
        {
            LocationData location = new LocationData();
            HttpClient httpClient = new HttpClient();

            // build request string:
            string encodedAddress = System.Net.WebUtility.HtmlEncode(address);


            string baseUrl = "https://maps.googleapis.com/maps/api/geocode/json?";
            string cityLookup = $"address={address}&region=us&key=AIzaSyAvHBuqmay0q_5_k3YKBm0irl4b2FobR7s";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl + cityLookup}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                LocationData deserializedLocation = JsonConvert.DeserializeObject<LocationData>(responseBody);

                location = deserializedLocation;

                _rAndr.takeRequestResponseSnapshot(request_string: $"{baseUrl + cityLookup}", response_string: responseBody.ToString(), time_stamp: DateTime.Now,
                                                    target_uri: $"{baseUrl + cityLookup}", http_status_code: response.StatusCode.ToString());

                return location;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot reach google because {e}");
                return location;
            }
        }

        public static DateTime GetDateTime(long unixTimeStamp)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, kind: System.DateTimeKind.Utc);

            long unixTimeStampInTicks = (long)(unixTimeStamp * TimeSpan.TicksPerSecond);

            DateTime dateTime = new DateTime(ticks: unixStart.Ticks + unixTimeStampInTicks, kind: System.DateTimeKind.Utc);
            return dateTime.ToLocalTime();
        }
    }
}