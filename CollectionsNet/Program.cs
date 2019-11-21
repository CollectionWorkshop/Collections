using System.Linq;
using CollectionsNet_Data;
using System;

namespace CollectionsNet
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Wczytanie danych z pliku CSV
            var pathToData = "results.csv";
            var dataProcessor = new GameDataProcessor();
            var fullGameData = dataProcessor.ProcessData(pathToData);
            var homeTeamData = fullGameData.Select(f => f.HomeTeam).ToArray();

            // Learning
            new Collections101().Execute();
            new Linq101(fullGameData).Execute();

            // Exercises
            new InitializationExercises().Exercise();
            new PerformanceExercises(homeTeamData).Exercise();
            new LinqExercises(fullGameData).Exercise();

            // Performance examples
            //QueueAndStackExamples.StackQueuePerformance(fullGameData);

            Console.ReadKey();
        }

    }
}