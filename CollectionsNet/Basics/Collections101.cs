using System;
using System.Collections.Generic;

namespace CollectionsNet
{
    public class Collections101
    {
        public void Execute()
        {
            // Podstawowe kolekcje
            //  Tablica
            //  - Tworzenie 
            int[] table1 = new int[3];
            table1[0] = 2;
            table1[1] = 3;
            table1[2] = 1;

            var table2 = new int[3] { 2, 3, 1 };
            //  - Operacje
            // UWAGA: 
            // Tablica jest statyczną statyczną strukturą i nie może zmieniać swojej wielkości
            // Nie można dodawać, ani usuwać elementów!

            // Można za to odwoływać się do dowolnego elementu w tablicy za pomocą indeksu od 0
            var secondArrayElement = table1[1];
            var tableLength = table1.Length;

            // Lista
            //  - Tworzenie
            List<int> list1 = new List<int>();
            list1.Add(2);
            list1.Add(3);
            list1.Add(1);

            var list2 = new List<int>() { 2, 3, 1 };
            //  - Operacje
            list2.Add(16);
            list2.AddRange(new int[] { 17, 18 });

            var secondListElement = list2[1];
            var listLength = list2.Count;
            var contains16 = list2.Contains(16);
            list2.Remove(16);
            list2.RemoveAt(1);

            // Słownik
            //  - Tworzenie
            var dictionary1 = new Dictionary<string, int>();
            dictionary1.Add("Polska", 2);
            dictionary1.Add("Mongolia", 1);

            var dictionary2 = new Dictionary<string, int>
            {
                { "Polska", 2 },
                { "Mongolia", 1 },
                // { "Polska", 3 },  // UWAGA: Klucz musi być unikalny
            };

            //  - Operacje
            dictionary2.Add("Holandia", 5);            
            dictionary2.Remove("Holandia");
            var dictionaryElements = dictionary2.Count;
            var isHolland = dictionary2.ContainsKey("Holandia");
            int value;
            if (dictionary2.TryGetValue("Holandia", out value))
            {
                // wykonaj operację jeśli jest element
            };
            var valueForPoland = dictionary2["Polska"];
            
            // Set
            //  - Tworzenie
            var hashSet = new HashSet<string>()
            {
                "Polska",
                "Niemcy," 
                // "Polska", // UWAGA: Klucz musi być unikalny podobnie jak to ma miejsce przy słownikach
            };

            //  - Operacje
            hashSet.Add("Francja");
            hashSet.Remove("Niemcy");
            hashSet.Contains("Polska");

            // Kolejka
            //  - Tworzenie
            var queue = new Queue<string>(new[] { "Polska", "Niemcy", "Francja", "Belgia" });

            //  - Operacje
            queue.Enqueue("Anglia");
            var pierwszyGracz = queue.Dequeue(); // Polska, pobieramy pierwszy element i usuwamy z kolejki
            var drugiGracz = queue.Peek();       // Tylko podglądamy


            // Stos
            //  - Tworzenie
            var stack = new Stack<string>(new[] { "Łódź", "Warszawa", "Aleksandrów Łódzki" });

            //  - Operacje
            stack.Push("Kutno");
            var firstElement = stack.Pop();    // Pobieramy pierwszy element oraz usuwamy ze stosu
            var secondElement = stack.Peek();     // Podglądamy jaki jest pierwszy element na stosie
        }
    }
}