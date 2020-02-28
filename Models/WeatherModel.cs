using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace weatherMvc.Models
{
    public class WeatherData
    {
        [Key]
        public int weatherDataId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int offset { get; set; }
        public string timezone { get; set; }
        public Currently currently { get; set; }
        public Minutely minutely { get; set; }
        public Hourly hourly { get; set; }
        public Daily daily { get; set; }
        public List<Alert> alerts { get; set; }
        public Flags flags { get; set; }
    }
    public class Currently
    {
        [Key]
        public int currentlyId { get; set; }
        public long time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public double nearestStormDistance { get; set; }
        public double precipIntensity { get; set; }
        public double precipIntensityError { get; set; }
        public double precipProbability { get; set; }
        public string precipType { get; set; }
        public double temperature { get; set; }
        public double apparentTemperature { get; set; }
        public double dewPoint { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
        public double windSpeed { get; set; }
        public double windGust { get; set; }
        public int windBearing { get; set; }
        public double cloudCover { get; set; }
        public int uvIndex { get; set; }
        public double visibility { get; set; }
        public double ozone { get; set; }
    }

    public class Minutely
    {
        [Key]
        public int minutelyId { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public List<MinutelyData> minutely_data { get; set; }
    }

    public class Hourly
    {
        [Key]
        public int hourlyId { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public List<HourlyData> hourly_data { get; set; }
    }

    
    public class Daily
    {
        [Key]
        public int dailyId { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public List<DailyData> daily_data { get; set; }
    }

    public class Alert
    {
        [Key]
        public int alertId { get; set; }
        List<AlertData> alert_data { get; set; }
    }

    public class Flags
    {
        [Key]
        public int flagsId { get; set; }
        public List<FlagSource> flag_sources { get; set; }
        public double neareststation { get; set; }
        public string units { get; set; }
    }

    // Nested classes: 
    public class MinutelyData
    {
        [Key]
        public int minutelyDataId { get; set; }
        public long time { get; set; }
        public double precipIntensity { get; set; }
        public double precipIntensityError { get; set; }
        public double precipProbability { get; set; }
        public string precipType { get; set; }
    }

    public class HourlyData
    {
        [Key]
        public int hourlyDataId { get; set; }
        public DateTime time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public double precipIntensity { get; set; }
        public double precipProbability { get; set; }
        public string precipType { get; set; }
        public double temperature { get; set; }
        public double apparentTemperature { get; set; }
        public double dewPoint { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
        public double windSpeed { get; set; }
        public double windGust { get; set; }
        public int windBearing { get; set; }
        public double cloudCover { get; set; }
        public int uvIndex { get; set; }
        public int visibility { get; set; }
        public double ozone { get; set; }
    }

    [JsonConverter(typeof(DailyData))]
    public class DailyData
    {
        [Key]
        [JsonPropertyName("daily.daily_data.dailyDataId")]
        public int dailyDataId { get; set; }

        [JsonPropertyName("daily.daily_data.time")]
        public DateTime time { get; set; }

        [JsonPropertyName("daily.daily_data.summary")]
        public string summary { get; set; }

        [JsonPropertyName("daily.daily_data.icon")]
        public string icon { get; set; }

        [JsonPropertyName("daily.daily_data.sunriseTime")]
        public DateTime sunriseTime { get; set; }

        [JsonPropertyName("daily.daily_data.sunsetTime")]
        public DateTime sunsetTime { get; set; }

        [JsonPropertyName("daily.daily_data.moonPhase")]
        public double moonPhase { get; set; }

        [JsonPropertyName("daily.daily_data.precipIntensity")]
        public double precipIntensity { get; set; }

        [JsonPropertyName("daily.daily_data.precipIntensityMax")]
        public double precipIntensityMax { get; set; }

        [JsonPropertyName("daily.daily_data.precipIntensityMaxTime")]
        public DateTime precipIntensityMaxTime { get; set; }

        [JsonPropertyName("daily.daily_data.precipProbability")]
        public double precipProbability { get; set; }

        [JsonPropertyName("daily.daily_data.precipType")]
        public string precipType { get; set; }

        [JsonPropertyName("daily.daily_data.temperatureHigh")]
        public double temperatureHigh { get; set; }

        [JsonPropertyName("daily.daily_data.temperatureHighTime")]
        public DateTime temperatureHighTime { get; set; }

        [JsonPropertyName("daily.daily_data.temperatureLow")]
        public double temperatureLow { get; set; }

        [JsonPropertyName("daily.daily_data.temperatureLowTime")]
        public DateTime temperatureLowTime { get; set; }

        [JsonPropertyName("daily.daily_data.apparentTemperatureHigh")]
        public double apparentTemperatureHigh { get; set; }
        public DateTime apparentTemperatureHighTime { get; set; }
        public double apparentTemperatureLow { get; set; }
        public DateTime apparentTemperatureLowTime { get; set; }
        public double dewPoint { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
        public double windSpeed { get; set; }
        public double windGust { get; set; }
        public DateTime windGustTime { get; set; }
        public int windBearing { get; set; }
        public double cloudCover { get; set; }
        public int uvIndex { get; set; }
        public DateTime uvIndexTime { get; set; }
        public double visibility { get; set; }
        public double ozone { get; set; }
        public double temperatureMin { get; set; }
        public DateTime temperatureMinTime { get; set; }
        public double temperatureMax { get; set; }
        public DateTime temperatureMaxTime { get; set; }
        public double apparentTemperatureMin { get; set; }
        public DateTime apparentTemperatureMinTime { get; set; }
        public double apparentTemperatureMax { get; set; }
        public DateTime apparentTemperatureMaxTime { get; set; }
    }

    public class AlertData
    {
        [Key]
        public int alertDataId { get; set; }
        public string title { get; set; }
        public List<AlertRegion> alert_regions { get; set; }
        public string severity { get; set; }
        public DateTime time { get; set; }
        public DateTime expires { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
    }

    public class FlagSource
    {
        [Key]
        public int flagSourceId { get; set; }
        public string flag_type { get; set; }
    }

    public class AlertRegion
    {
        [Key]
        public int alertRegionId { get; set; }
        public string regions { get; set; }
    }

    public class LocationData
    {
        [Key]
        public int locationDataId { get; set; }
        public List<AddressComponents> address_components { get; set; }
        public string formatted_address { get; set; }
        public string status { get; set; }
        public double location_lat { get; set; }
        public double location_long { get; set; }
        public string google_place_id { get; set; }
    }

    public class AddressComponents
    {
        [Key]
        public int addressComponentsId { get; set; }
        public string street_number { get; set; }
        public string route { get; set; } // street
        public string locality { get; set; } // city
        public string county { get; set; } // google calls this: administrative_area_level_2
        public string state { get; set; }
        public string country { get; set; }
        public string postal_code { get; set; }
        public string postal_code_suffix { get; set; }


    }

}
