using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LinqLab
{
    class Program
    {
        delegate bool filter(JToken thing);
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: Output all of the neighborhoods in this data list.");
            int counter = 0;
            IList<JToken> list = ParseJSON()["features"].ToList();
            foreach(JToken feat in list)
            {
                counter++;
            }
            Console.WriteLine(counter);
            Console.WriteLine("Question 2: Filter out all the neighborhoods that do not have any names.");
            Console.WriteLine("Question 3: Remove the duplicates.");
            Console.WriteLine("Question 4: Rewrite the queries from above and consolidate all into one single query.");
            Console.WriteLine("Question 5: Rewrite at least one of these questions only using the opposing method.");
        }

        public static JObject ParseJSON()
        {
            using (StreamReader reader = File.OpenText(@"../../../data.json"))
            {
                JObject data = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                return data;
            }
        }
    }
}
