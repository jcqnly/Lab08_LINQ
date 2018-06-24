using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQinManhatten.Classes
{
    public class Properties
    {
        [JsonProperty]
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Borough { get; set; }
        public string Neighborhood { get; set; }
        public string County { get; set; }
    }
}
