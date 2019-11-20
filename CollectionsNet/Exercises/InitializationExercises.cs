using System.Collections.Generic;
using System.Linq;
using System;

namespace CollectionsNet
{
    public class InitializationExercises
    {
        public void Exercise()
        {
            // TODO: Stwórz listę 3 imion o nazwie names
            //var names = 

            // TODO: Stwórz tablicę 3 nazwisk o nazwie surnames
            //var surnames = 

            // TODO: Stwórz słownik kilku tłumaczeń: angielski - polski o nazwie translations
            //var translations = 

            // TODO: Stwórz hashset kilku znanych słowek o nazwie knownWords
            //var knownWords = 

            // TODO: Stwórz kolejkę zawierającą nazwy ciekawych miejsc miejsca o nazwie places
            //var places = 

            // TODO: Stwórz stos zawierający nazwy obowiązki, które 
            //var chores = 

            // TODO: Odkomentuj linijkę
            //DisplaySillyStory(names, surnames, translations, knownWords, places, chores);
        }

        public void DisplaySillyStory(IList<string> names, string[] surnames, IDictionary<string, string> translations, ISet<string> knownWords, Queue<string> places, Stack<string> chores)
        {
            var elements = names.Count;
            if ((elements != surnames.Count() || elements != 3) || !places.Any() || !translations.Any() || !knownWords.Any() || !chores.Any())
            {
                Console.WriteLine("Exercise has not been executed properly. Please try again ;)");
                return;                
            }

            var storyElements = new List<Func<string>>
            {
                () => $"would like to go to {string.Join(", ", places.ToArray())}",
                () => $"knows the following words in English: {string.Join(", ", knownWords.ToArray())} ",
                () => $"needs to do following chores during the weekend: {string.Join(", ", chores.ToArray())}"
            };

            Console.WriteLine("Following characters are created:");
            for (var i = 0; i < elements; i++)
            {
                Console.WriteLine($" - {names[i]} {surnames[i]} {storyElements[i]()}");
            }
        }
    }
}