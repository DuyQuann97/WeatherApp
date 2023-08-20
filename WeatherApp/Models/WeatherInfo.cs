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
        public Current Current { get; set; }

        
    }

    public class  Location 
    {
        // Name City 
        public string Name { get; set; }

        // Latitude & Longtitude
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lon")]
        public double Longtitude{ get; set; }

    }

    public class Current
    {
        [JsonProperty("temp_c")]
        public float TempC { get; set; }
        [JsonProperty("temp_f")]
        public float TempF { get; set; }
        public float uv {get; set; }
        public Condition condition { get; set; }


        public class Condition
        {
     
            public string text { get; set; }
            
            public string icon { get; set; }
        }

    }
}
