using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQinManhatten.Classes
{
    public class RootObject
    {
        [JsonProperty]
        public string Type { get; set; }
        public List<Feature> Features { get; set; }
    }
}
