using CsvHelper.Configuration;

namespace CollectionsNet_Linq.Model
{
    public class GameDataMap : ClassMap<GameData>
    {
        public GameDataMap()
        {
            Map(m => m.Date).Name("Date");
            Map(m => m.HomeTeam).Name("HomeTeam");
            Map(m => m.AwayTeam).Name("AwayTeam");
            Map(m => m.HomeScore).Name("HomeScore");
            Map(m => m.AwayScore).Name("AwayScore");
            Map(m => m.Tournament).Name("Tournament");
            Map(m => m.City).Name("City");
            Map(m => m.Country).Name("Country");
            Map(m => m.Neutral).Name("Neutral");
        }
    }
}