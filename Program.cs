using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        public delegate bool Filter(string item);
        static void Main(string[] args)
        {
            string[] Names = { "Mercury", "Mars", "Venus", "Earth", "Neptune", "Uranus", "Saturn", "Jupiter", "Sun" };

            FilterNames(Names, lessThanFive);
            FilterNames(Names, exactlyFive);
            FilterNames(Names, moreThanFive);
        }

        public static bool lessThanFive(string name) { return (name.Length < 5); }
        public static bool exactlyFive(string name) { return (name.Length == 5); }
        public static bool moreThanFive(string name) { return (name.Length > 5); }

        public static void FilterNames(string[] items, Filter filter)
        {
            List<string> familyNames = new List<string>();

            foreach (var item in items)
            {
                if (filter(item))
                    familyNames.Add(item);
            }

            Console.WriteLine(string.Join(",", familyNames));
        }
    }
}