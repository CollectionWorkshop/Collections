using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace CollectionsNet
{
    public class PerformanceExercises
    {
        private string[] elements;
        private IList<string> listElements = new List<string>();
        private IList<string> arrayElements = Array.Empty<string>();
        private IDictionary<string, string> dictionaryElements = new Dictionary<string, string>();
        private ISet<string> setElements = new HashSet<string>();

        public PerformanceExercises(string[] elements)
        {
            this.elements = elements;
        }

        public void Exercise()
        {
            Execute(nameof(AddCompare), AddCompare(elements));
            Execute(nameof(RetriveCompare), RetriveCompare(elements));
            Execute(nameof(RemoveCompare), RemoveCompare(elements));
        }

        public Action[] AddCompare(string[] toAdd)
        {
            return new Action[]
            {
                () =>
                {
                    // TODO: załaduj dane do listy

                    // TODO: Przypisz do zmiennej
                    // listElements = 
                },
                () =>
                {
                    // TODO: a może do listy można załadować dane inaczej?
                },
                () =>
                {
                    // TODO: załaduje dane do tablicy
                                        
                    // TODO: Przypisz do zmiennej
                    // arrayElements = 
                },
                () =>
                {
                    // TODO: załaduje dane do słownika, jako wartość możesz użyć string.Empty
                                        
                    // TODO: Przypisz do zmiennej
                    // dictionaryElements = 
                },
                () =>
                {
                    // TODO: załaduje dane do słownika, jako wartość możesz użyć string.Empty
                                        
                    // TODO: Przypisz do zmiennej
                    // setElements = 
                },
                () =>
                {
                    // TODO: eksperymentuj dalej
                },
            };
        }

        public Action[] RetriveCompare(string[] toCheck)
        {
            return new Action[]
            {
                () =>
                {
                    // TODO: sprawdz dane na listElements
                },
                () =>
                {
                    // TODO: sprawdz dane z arrayElements
                },
                () =>
                {
                    // TODO: sprawdz dane z dictionaryElements
                },
                () =>
                {
                   // TODO: sprawdz dane z setElements
                },
            };
        }

        private Action[] RemoveCompare(string[] elements)
        {
            return new Action[]
            {
                () =>
                {
                    // TODO: usun dane z listElements
                },
                () =>
                {
                    // TODO: usun dane z arrayElements
                },
                () =>
                {
                    // TODO: usun dane z dictionaryElements
                },
                () =>
                {
                   // TODO: usun dane z setElements
                },
            };
        }

        private void Execute(string header, Action[] operations)
        {
            Console.WriteLine($" *** {header} ***");
            var watch = Stopwatch.StartNew();
            var operationId = 0;
            foreach (var operation in operations)
            {
                watch.Restart();
                operation();
                Console.WriteLine($"Operation {++operationId} took {watch.ElapsedTicks} ticks");
            }
        }
    }
}