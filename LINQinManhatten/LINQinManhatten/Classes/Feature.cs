using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQinManhatten.Classes
{
    public class Feature
    {
        [JsonProperty]
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
    }
}
