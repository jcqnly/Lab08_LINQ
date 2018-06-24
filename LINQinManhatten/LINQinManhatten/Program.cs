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
            Console.WriteLine("<----------------All Neighborhoods--------------->");
            foreach (var hoods in neighborhoods)
            {
                Console.WriteLine(hoods);
            }
            Console.ReadLine();

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
            Console.Clear();
            Console.WriteLine("<-------------Non Null Neighborhoods------------>");
            foreach (var hoods in neighborhoods)
            {
                Console.WriteLine(hoods);
            }
            Console.ReadLine();
            FilterOutDupes(FeatureCollection);
        }

        /// <summary>
        /// Filters out dupes with a LINQ query
        /// </summary>
        /// <param name="FeatureCollection"></param>
        public static void FilterOutDupes(RootObject FeatureCollection)
        {
            var distinctNeighborhoods = from x in FeatureCollection.Features
                                        group x by x.Properties.Neighborhood into HoodGroup
                                        where HoodGroup.Key != ""
                                        orderby HoodGroup.Key
                                        select HoodGroup.Key;

            Console.Clear();
            Console.WriteLine("<-------------Neighborhood With Dupes Removed------------>");
            foreach (var hoods in distinctNeighborhoods)
            {
                Console.WriteLine(hoods);
            }
            Console.ReadLine();

            SingleQuery(FeatureCollection);
        }

        /// <summary>
        /// Query that combines the previous 3 queries into 1 using a Lambda expression
        /// </summary>
        /// <param name="FeatureCollection"></param>
        public static void SingleQuery(RootObject FeatureCollection)
        {
            var neighborhoods = FeatureCollection.Features.Where(n => n.Properties.Neighborhood != "")
                                                          .GroupBy(g => g.Properties.Neighborhood)
                                                          .Select(s => s.Key);

            Console.Clear();
            Console.WriteLine("<-------------Neighborhoods as a Result of a Single Query ------------>");
            foreach (var hoods in neighborhoods)
            {
                Console.WriteLine(hoods);
            }
            Console.ReadLine();
            FinalRewriteStatement(FeatureCollection);
        }

        /// <summary>
        /// Lambda expression in previous method rewritten as a LINQ query
        /// </summary>
        /// <param name="FeatureCollection"></param>
        public static void FinalRewriteStatement(RootObject FeatureCollection)
        {
            var neighborhoods = from i in FeatureCollection.Features
                              where i.Properties.Neighborhood != ""
                              group i.Properties.Neighborhood 
                              by i.Properties.Neighborhood
                              into HoodGroup
                              select HoodGroup.Key;

            Console.Clear();
            Console.WriteLine("<-------------Final Query ------------>");
            foreach (var hoods in neighborhoods)
            {
                Console.WriteLine(hoods);
            }
            Console.ReadLine();
        }
    }
}
