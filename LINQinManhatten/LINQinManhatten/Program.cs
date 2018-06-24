using LINQinManhatten.Classes;
using System;
using System.IO;
using System.Linq;

namespace LINQinManhatten
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadJSON();
        }

        /// <summary>
        /// Read the entire JSON file into an object, pass that object
        /// to another method to start going through the data
        /// </summary>
        public static void LoadJSON()
        {
            string path = @"../../../../../data.json";
            //read the entire json file into an instantiation of the RootObject called FeatureCollection
            RootObject FeatureCollection = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(
                File.ReadAllText(path));

            ShowNeigborhoods(FeatureCollection);
        }

        public static void ShowNeigborhoods(RootObject FeatureCollection)
        {
            var neighborhoods = from i in FeatureCollection.Features
                                select i.Properties.Neighborhood;
            foreach (var hoods in neighborhoods)
            {
                Console.WriteLine(hoods);
            }
        }
    }
}
