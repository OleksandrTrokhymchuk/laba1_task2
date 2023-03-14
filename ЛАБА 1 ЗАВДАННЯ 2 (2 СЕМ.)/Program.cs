using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Xml.Linq;
using Newtonsoft;
using Newtonsoft.Json;

namespace sasha
{
    class Program
    {

        static void Main(string[] args)
        {

            Dictionary<string, string> people = new Dictionary<string, string>();
            Random random = new Random();
            string[] names = { "John", "Bill", "Alex", "Joseph", "Donald" };
            string[] cities = { "New York", "Los Angeles", "Las Vegas", "Washington", "San Francisco" };

            for (int i = 0; i < 5; i++)
            {
                people.Add(names[i], cities[random.Next(5)]);
            }

            Console.WriteLine("List before:");
            foreach (KeyValuePair<string, string> i in people)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }

            var sortedKeys = from i in people.Keys
                             orderby i
                             select i;

            Console.WriteLine("\nList after (only keys):");
            foreach (var key in sortedKeys)
            {
                Console.WriteLine(key);
            }


            string json = JsonConvert.SerializeObject(people);
            Console.WriteLine("\nJSON:\n" + json);

           


            Console.ReadLine();

        }
    }
}






