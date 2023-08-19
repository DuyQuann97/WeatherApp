using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherInfo
    {
        public Location Location { get; set; }
    }

    public class  Location 
    {
        public string Name { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lon")]
        public double Longtitude{ get; set; } 
    }
}
