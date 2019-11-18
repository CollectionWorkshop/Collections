using CollectionsNet;
using CollectionsNet_Linq.Model;

namespace CollectionsNet_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytanie danych z pliku CSV
            var pathToData = "Data/results.csv";
            var dataProcessor = new GameDataProcessor();
            var gameData = dataProcessor.ProcessData(pathToData);


            QueueAndStackExamples.StackAndQueueIntroduction();

            QueueAndStackExamples.StackQueuePerformance(gameData);
        }
    }
}