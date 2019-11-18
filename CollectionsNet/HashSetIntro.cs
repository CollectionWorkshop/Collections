using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CollectionsNet
{
    public static class HashSetIntro
    {
        public static void AddCompare(List<string> list, HashSet<string> hashSet, string[] toAdd)
        {
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < toAdd.Length; i++)
            {
                list.Add(toAdd[i]);
            }

            Console.WriteLine(watch.ElapsedTicks);
            watch.Restart();

            for (var i = 0; i < toAdd.Length; i++)
            {
                hashSet.Add(toAdd[i]);
            }
            Console.WriteLine(watch.ElapsedTicks);
        }

        public static void ContainsCompare(List<string> list, HashSet<string> hashSet, string[] toCheck)
        {
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < toCheck.Length; i++)
            {
                var x = list.Contains(toCheck[i]);
            }

            Console.WriteLine(watch.ElapsedTicks);
            watch.Restart();

            for (var i = 0; i < toCheck.Length; i++)
            {
                var x =hashSet.Contains(toCheck[i]);
            }
            Console.WriteLine(watch.ElapsedTicks);
        }
    }
}
