using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQinManhatten.Classes
{
    public class Geometry
    {
        [JsonProperty]
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }
}
