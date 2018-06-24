using LINQinManhatten.Classes;
using System;
using System.IO;
using System.Linq;

namespace LINQinManhatten
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoadJSON();
        }

        /// <summary>
        /// Read the entire JSON file into an object that is
        /// instantiated from the RootObject class, pass that object
        /// to another method to start parsing the data
        /// </summary>
        public static void LoadJSON()
        {
            //There were build errors, so the data file is on the same
            //level as the gitignore file
            string path = @"../../../../../data.json";
            //read the entire json file into an instantiation of the RootObject called FeatureCollection
            //use Sysem.IO to ReadAllText from that file
            RootObject FeatureCollection = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(
                File.ReadAllText(path));

            ShowNeigborhoods(FeatureCollection);
        }

        /// <summary>
        /// parse through the data for only the neighborhoods
        /// output all the neighborhoods
        /// </summary>
        /// <param name="FeatureCollection"></param>
        public static void ShowNeigborhoods(RootObject FeatureCollection)
        {
            //LINQ query
            var neighborhoods = from i in FeatureCollection.Features
                                select i.Properties.Neighborhood;
            foreach (var hoods in neighborhoods)
            {
                Console.WriteLine(hoods);
            }
            Console.Read();
            Console.Clear();
            FilterNoNameNeighborhoods(FeatureCollection);
        }

        /// <summary>
        /// Filter out entries that have no name for the neighborhood
        /// </summary>
        /// <param name="FeatureCollection"></param>
        public static void FilterNoNameNeighborhoods(RootObject FeatureCollection)
        {
            var neighborhoods = from x in FeatureCollection.Features
                                where x.Properties.Neighborhood != ""
                                select x.Properties.Neighborhood;
            foreach (var hoods in neighborhoods)
            {
                Console.WriteLine(hoods);
            }
        }

        public static void FilterOutDupes(RootObject FeatureCollection)
        {

        }
    }
}
