using CollectionsNet_Data;

namespace CollectionsNet_Linq
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Program
    {
        public static void Main(string[] args)
        {
            //Wczytanie danych z pliku CSV
            var pathToData = "Data/results.csv";
            var dataProcessor = new GameDataProcessor();
            var gameData = dataProcessor.ProcessData(pathToData);
        }
    }
}
