using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CollectionsNet
{
    public static class PerformanceCompare
    {
        public static void AddCompare(string[] toAdd)
        {
            var watch = Stopwatch.StartNew();

            var list = new List<string>();

            for (var i = 0; i < toAdd.Length; i++)
            {
                list.Add(toAdd[i]);
            }
            Console.WriteLine(watch.ElapsedTicks);
            watch.Restart();

            list.AddRange(toAdd);
            Console.WriteLine(watch.ElapsedTicks);
            watch.Restart();

            for (var i = 0; i < toAdd.Length; i++)
            {
                //hashSet.Add(toAdd[i]);
            }
            Console.WriteLine(watch.ElapsedTicks);
        }
        
        
        
        public static void RetriveCompare(string[] toCheck)
        {
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < toCheck.Length; i++)
            {
                //var x = list.Contains(toCheck[i]);
            }

            Console.WriteLine(watch.ElapsedTicks);
            watch.Restart();

            for (var i = 0; i < toCheck.Length; i++)
            {
                //var x =hashSet.Contains(toCheck[i]);
            }
            Console.WriteLine(watch.ElapsedTicks);
        }
    }
}
