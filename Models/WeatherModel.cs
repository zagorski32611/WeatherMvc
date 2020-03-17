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
        public LocationData location { get; set; }
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
        public List<DailyData> data { get; set; }
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
        public long time { get; set; }
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
        [JsonPropertyName("daily.data.dailyDataId")]
        public int dailyDataId { get; set; }

        [JsonPropertyName("daily.data.time")]
        public long time { get; set; }

        [JsonPropertyName("daily.data.summary")]
        public string summary { get; set; }

        [JsonPropertyName("daily.data.icon")]
        public string icon { get; set; }

        [JsonPropertyName("daily.data.sunriseTime")]
        public long sunriseTime { get; set; }

        [JsonPropertyName("daily.data.sunsetTime")]
        public long sunsetTime { get; set; }

        [JsonPropertyName("daily.data.moonPhase")]
        public double moonPhase { get; set; }

        [JsonPropertyName("daily.data.precipIntensity")]
        public double precipIntensity { get; set; }

        [JsonPropertyName("daily.data.precipIntensityMax")]
        public double precipIntensityMax { get; set; }

        [JsonPropertyName("daily.data.precipIntensityMaxTime")]
        public long precipIntensityMaxTime { get; set; }

        [JsonPropertyName("daily.data.precipProbability")]
        public double precipProbability { get; set; }

        [JsonPropertyName("daily.data.precipType")]
        public string precipType { get; set; }

        [JsonPropertyName("daily.data.temperatureHigh")]
        public double temperatureHigh { get; set; }

        [JsonPropertyName("daily.data.temperatureHighTime")]
        public long temperatureHighTime { get; set; }

        [JsonPropertyName("daily.data.temperatureLow")]
        public double temperatureLow { get; set; }

        [JsonPropertyName("daily.data.temperatureLowTime")]
        public long temperatureLowTime { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureHigh")]
        public double apparentTemperatureHigh { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureHighTime")]
        public long apparentTemperatureHighTime { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureLow")]
        public double apparentTemperatureLow { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureHighTime")]
        public long apparentTemperatureLowTime { get; set; }

        [JsonPropertyName("daily.data.dewPoint")]
        public double dewPoint { get; set; }

        [JsonPropertyName("daily.data.humidity")]
        public double humidity { get; set; }
        [JsonPropertyName("daily.data.pressure")]
        public double pressure { get; set; }

        [JsonPropertyName("daily.data.windSpeed")]
        public double windSpeed { get; set; }
        [JsonPropertyName("daily.data.windGust")]
        public double windGust { get; set; }
        [JsonPropertyName("daily.data.windGustTime")]
        public long windGustTime { get; set; }

        [JsonPropertyName("daily.data.windBearing")]
        public int windBearing { get; set; }

        [JsonPropertyName("daily.data.cloudCover")]
        public double cloudCover { get; set; }

        [JsonPropertyName("daily.data.uvIndex")]
        public int uvIndex { get; set; }

        [JsonPropertyName("daily.data.uvIndexTime")]
        public long uvIndexTime { get; set; }

        [JsonPropertyName("daily.data.visibility")]
        public double visibility { get; set; }

        [JsonPropertyName("daily.data.ozone")]
        public double ozone { get; set; }
        [JsonPropertyName("daily.data.temperatureMin")]
        public double temperatureMin { get; set; }

        [JsonPropertyName("daily.data.temeratueMinTime")]
        public long temperatureMinTime { get; set; }

        [JsonPropertyName("daily.data.temperatureMax")]
        public double temperatureMax { get; set; }

        [JsonPropertyName("daily.data.temperatureMaxTime")]
        public long temperatureMaxTime { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureMin")]
        public double apparentTemperatureMin { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureMinTime")]
        public long apparentTemperatureMinTime { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureMax")]
        public double apparentTemperatureMax { get; set; }

        [JsonPropertyName("daily.data.apparentTemperatureMaxTime")]
        public long apparentTemperatureMaxTime { get; set; }
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

        public List<Result> results { get; set; }

        public string status { get; set; }

        public string searchAddress {get; set;}

        public double searchLat {get; set; }

        public double searchLng {get; set; }
    }

    [JsonConverter(typeof(Result))]
    public class Result
    {
        [JsonPropertyName("results.formatted_address")]
        public string formatted_address { get; set; }

        [JsonPropertyName("results.place_id")]
        public string place_id { get; set; }

        [JsonPropertyName("results.address_components")]
        public List<AddressComponent> address_components { get; set; }

        [JsonPropertyName("results.geometry")]
        public Geometry geometry { get; set; }

        [JsonPropertyName("results.types")]
        public List<string> types { get; set; }
    }

    public class AddressComponent
    {
        [Key]
        public int addressComponentId { get; set; }

        [JsonPropertyName("results.address_components.long_name")]
        public string long_name { get; set; }

        [JsonPropertyName("results.address_components.short_name")]
        public string short_name { get; set; }

        [JsonPropertyName("results.address_components.types")]
        public List<string> types { get; set; }
    }



    public class Geometry
    {
        [Key]
        public int geometryId { get; set; }

        [JsonPropertyName("results.geometry.location_type")]
        public string location_type { get; set; }

        [JsonPropertyName("results.geometry.bounds")]
        public Bounds bounds { get; set; }

        [JsonPropertyName("results.geometry.bounds")]
        public Location location { get; set; }

        [JsonPropertyName("results.geometry.viewport")]
        public Viewport viewport { get; set; }
    }



    public class Location
    {
        [Key]
        public int locationId { get; set; }

        [JsonPropertyName("results.geometry.location.lat")]
        public double lat { get; set; }

        [JsonPropertyName("results.geometry.location.lng")]
        public double lng { get; set; }
    }


    public class Viewport
    {
        public Northeast northeast { get; set; }
        public Southwest southwest { get; set; }
    }


    public class Bounds
    {
        public Northeast northeast { get; set; }
        public Southwest southwest { get; set; }
    }


    public class Northeast
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Southwest
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

}
