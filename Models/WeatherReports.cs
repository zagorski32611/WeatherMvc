using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace weatherMvc.Models
{
    public class WeatherReport : WeatherData
    {
        // first define fields unique to the reports, then bring in the weather data:
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public WeatherData weather { get; set; }
        public LocationData locationData { get; set; }
        public List<Daily> resultDays { get; set; }

    }
}