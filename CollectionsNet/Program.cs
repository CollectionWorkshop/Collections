using System.Collections.Generic;
using System.Linq;
using CollectionsNet_Data;

namespace CollectionsNet
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            //Wczytanie danych z pliku CSV
            var pathToData = "Project files/results.csv";
            var dataProcessor = new GameDataProcessor();
            var data = dataProcessor.ProcessData(pathToData).Select(f => f.HomeTeam).ToArray();


            //przerobicze string na klase gameData i odac ovveride GetHashet.
            HashSetIntro.AddCompare(new List<string>(), new HashSet<string>(), data);

            //var list = new List<string>().AddRange(data);
            //HashSetIntro.ContainsCompare();
            Console.ReadKey();
        }
    }
}
