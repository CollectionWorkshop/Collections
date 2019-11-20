using System.Collections.Generic;
using System.Linq;
using CollectionsNet_Data;

namespace CollectionsNet
{
    using System;
    using System.Diagnostics;

    public static class Program
    {
        public static void Main(string[] args)
        {
            //Wczytanie danych z pliku CSV
            var pathToData = "Project files/results.csv";
            var dataProcessor = new GameDataProcessor();
            var fullGameData = dataProcessor.ProcessData(pathToData);
            var homeTeamData = fullGameData.Select(f => f.HomeTeam).ToArray();

            (new InitializationExercises()).Exercise();
            (new PerformanceExercises()).Exercise();

            PerformanceCompare.AddCompare(homeTeamData);
            //var list = new List<string>().AddRange(data);
            //HashSetIntro.ContainsCompare();

            // QUEUE AND STACK
            QueueAndStackExamples.StackAndQueueIntroduction();
            //QueueAndStackExamples.StackQueuePerformance(fullGameData);

            Console.ReadKey();
        }

    }


    public class InitializationExercises
    {
        public void Exercise()
        {
            // TODO: Stwórz listę ulubionych imino i dodaj do niej kilka imion i odkomentuj
            
            // var names = 
            // ShowStats(names)

            // TODO: Stwórz tablicę 
        }

        private void ShowStats(IEnumerable<string> names)
        {
            Console.WriteLine($"Number of names: {names.Count()}");
            Console.WriteLine($"Longest name: {names.Max(x => x.Length)}");            
        }
    }

    public class PerformanceExercises
    {
        public void Exercise()
        {
            // TODO: Stwórz listę ulubionych imino i dodaj do niej kilka imion i odkomentuj

            // var imiona = 
            // ShowStats()

            // AddCompare(...)
            // RetriveCompare( ...)
        }

        public static void AddCompare(string[] toAdd)
        {
            var watch = Stopwatch.StartNew();
            // TODO
            Console.WriteLine(watch.ElapsedTicks);
            watch.Restart();

            var list = new List<string>();

            foreach (var element in toAdd)
            {
                list.Add(element);
            }
            //TODO: AddRange
            //TODO: Array
            //TODO: 
            //Console.WriteLine(watch.ElapsedTicks);
            //watch.Restart();
        }


        public static void RetriveCompare(string[] toCheck)
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
                var x = hashSet.Contains(toCheck[i]);
            }
            Console.WriteLine(watch.ElapsedTicks);
        }
    }

    public class LinqExercises
    {
        public void Exercise()
        {
            // TODO: w których miastach Polacy wygrali z różnicą wyższa niż 1 bramka
            // TODO: w których miastach Polacy najczesciej wygrywali
            // TODO: z która dużyną Polacy najczęsciej wygrywali
            // TODO: z którą drużyną Polacy najczęsciej przegrywali
            // TODO: które drużyny występwały w FIFA World Cup 
            // TODO*: Ktory kraj faworyzuje najbardziej swoich piłkarzy w meczu rozgrywanym w kraju

            // var imiona = 
            // ShowStats()
        }
    }
}