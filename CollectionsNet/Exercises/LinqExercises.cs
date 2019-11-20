using CollectionsNet_Data;
using System.Collections.Generic;

namespace CollectionsNet
{
    public class LinqExercises
    {
        private readonly IEnumerable<GameData> gameData;

        public LinqExercises(IEnumerable<GameData> gameData)
        {
            this.gameData = gameData;
        }

        public void Exercise()
        {
            // TODO: w których miastach Polacy wygrali z różnicą wyższa niż 1 bramka

            // TODO: w których miastach Polacy najczesciej wygrywali
            
            // TODO: z która dużyną Polacy najczęsciej wygrywali
            
            // TODO: z którą drużyną Polacy najczęsciej przegrywali
            
            // TODO: które drużyny występwały w FIFA World Cup 
            
            // TODO*: Ktory kraj faworyzuje najbardziej swoich piłkarzy w meczu rozgrywanym w kraju
        }
    }
}