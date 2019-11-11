using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CollectionsNet_Linq.Model
{
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
