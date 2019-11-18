namespace CollectionsNet_Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using CsvHelper;

    public class GameDataProcessor
    {
        public IEnumerable<GameData> ProcessData(string pathToData)
        {
            using (var reader = new StreamReader(pathToData))
            {
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.Delimiter = ",";
                    csv.Configuration.RegisterClassMap<GameDataMap>();
                    var records = csv.GetRecords<GameData>().ToList();
                    return records;
                }
            }
        }
    }
}
