using System.Collections.Generic;
using System.Linq;
using CollectionsNet_Data;

namespace CollectionsNet
{
    public class Linq101
    {
        private readonly IEnumerable<GameData> gameData;

        public Linq101(IEnumerable<GameData> gameData)
        {
            this.gameData = gameData;
        }

        public void Execute()
        {
            // Analiza danych z użyciem linq
            SimpleQueryingData(gameData); // Wybór danych z kolekcji wg wybranego kryterium
            SimpleDataGrouping(gameData); // Grupowanie danych 
            QueryGamesAwayVsHomeAnalysis(gameData); // Analiza danych wykorzystująca zdobytą wiedzę
        }

        //Wylistujmy wszystkie mecze rozegrane przez polskich piłkarzy
        private static void SimpleQueryingData(IEnumerable<GameData> footballData)
        {
            // Linq
            var polandScoresLinq = (from games in footballData
                                    where games.HomeTeam.Equals("Poland") || games.AwayTeam.Equals("Poland")
                                    select games).ToList();

            // Lambda
            var polandScoresLambda = footballData
                .Where(f => f.HomeTeam.Equals("Poland") || f.AwayTeam.Equals("Poland"))
                .ToList();

            var countries = footballData.Select(x => x.Country).Distinct();

            var averageAwayScore = footballData.Average(x => x.AwayScore);
            var maxAwayScore = footballData.Max(x => x.AwayScore);
            var minAwayScore = footballData.Min(x => x.AwayScore);

            // UWAGA: Wyrażenia Linq są 'lazy evaluated'
            //        Można je materializować za pomocą metod: ToList, ToArray, ToDictionary ...  
        }

        // W którym roku polscy piłkarze wygrali najwięcej meczów
        private static void SimpleDataGrouping(IEnumerable<GameData> footballData)
        {
            //var groupedWinsByYear = footballData
            //    .Where(f => f.HomeTeam.Equals("Poland") && f.HomeScore > f.AwayScore || f.AwayTeam.Equals("Poland") && f.AwayScore > f.HomeScore) // Wybierzmy mecze wygrane przez Polaków jako gospodarze i goście
            //    .GroupBy(f => f.Date.Year) // Pogrupujmy mecze po dacie (uwzględniając tylko rok)
            //    .Select(f => (f.Key, f.Count())) // Wybierzmy dane w parze rok - ilosc wygranych
            //    .ToDictionary(k => k.Key, v => v.Item2) // wpiszmy dane tymczasowo do słownika żeby je jeszcze posortować
            //    .OrderByDescending(f => f.Value) // posortujmy malejąco po ilości wygranch                
            //    .Take(3) // Wybierzmy top 3 najlepszych lat;                
            //    .ToList(); // wpiszmy do listy
        }

        // Ktory kraj faworyzuje najbardziej swoich piłkarzy w meczu rozgrywanym w kraju
        private static void QueryGamesAwayVsHomeAnalysis(IEnumerable<GameData> footballData)
        {
            // Policzmy ile meczów w danym kraju zostało wygranych przez zespół gospodarzy
            //var homeWinningsperCountry = footballData
            //    .Where(f => f.AwayScore < f.HomeScore) // tam gdzie gospodarze wygrali 
            //    .GroupBy(f => f.Country) // pogrupujmy zbiór wg kraju
            //    .Select(f => (f.Key, f.Count())) // wybierzmy liczebność każdej z grup
            //    .ToDictionary(k => k.Key, v => v.Item2); // wpiszmy dane do słownika kraj-ilość wygranych

            // Do wyliczenia proporcji, wyznaczmy ile meczów zostało rozgrywanych w danym kraju
            //var totalGamesPerCountry = footballData
            //    .GroupBy(f => f.Country) // pogrupujmy cały zbiór wg kraju
            //    .Select(f => (f.Key, f.Count())) // zbierzmy liczebność każdej z grup
            //    .ToDictionary(k => k.Key, v => v.Item2); // wpiszmy dane do słownika kraj-ilość meczów

            //var countryBias = new Dictionary<string, float>();

            //// Dla każdego kraju wyliczmy proporcję meczy wygranych przez gospodarzy do wszystkich rozegranych w danym kraju
            //foreach (var country in homeWinningsperCountry.Keys)
            //{
            //    var homeWinToTotal = (float)homeWinningsperCountry[country] / (float)totalGamesPerCountry[country];
            //    countryBias.Add(country, homeWinToTotal);
            //}

            //var countryBiasLinq = new Dictionary<string, float>();

            //// Alternatywnie powyższą pętlę można wykonać jedną liniką (wynik taki sam): 
            //homeWinningsperCountry.Keys.ToList().ForEach(k => countryBiasLinq.Add(k, (float)homeWinningsperCountry[k] / (float)totalGamesPerCountry[k]));

            //// Posortujmy malejąco po wynikach obliczenia proporcji, wskazując które kraje częściej wygrywają w roli gospodarza
            //var sortedBias = from biasEntry in countryBias orderby biasEntry.Value descending select biasEntry;
        }
    }
}