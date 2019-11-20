using CollectionsNet_Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CollectionsNet
{
    public static class QueueAndStackExamples
    {
        public static void StackQueuePerformance(IEnumerable<GameData> footballData)
        {
            Stack<GameData> footballDataStack = new Stack<GameData>(footballData); // convert to Stack
            PerformanceStackVsList(footballData.ToList(), footballDataStack);

            Queue<GameData> footballDataQueue = new Queue<GameData>(footballData); // convert to Queue
            PerformanceOfQueueVsList(footballData.ToList(), footballDataQueue);

            PerformanceArrayVsList(footballData.ToList(), footballData.ToArray());
        }

        static void PerformanceArrayVsList(List<GameData> listOfGames, GameData[] stackGameData)
        {
            Console.WriteLine("\n\n**** ARRAY VS LIST PERFORMANCE ****\n\n");

            GameData placeholderGameData;

            var watch = Stopwatch.StartNew();
            var lengthOfStack = stackGameData.Length;
            for (var i = 0; i < lengthOfStack; i++)
            {
                placeholderGameData = stackGameData[i];
            }
            Console.WriteLine($"Measured performance of array indexing operation with {lengthOfStack} elements: {watch.ElapsedTicks}");
            watch.Restart();

            for (var i = 0; i < lengthOfStack; i++)
            {
                placeholderGameData = listOfGames[i];
            }
            Console.WriteLine($"Measured performance of List indexing operation with {lengthOfStack} elements: {watch.ElapsedTicks}");

            Console.ReadKey();
        }

        static void PerformanceStackVsList(List<GameData> listOfGames, Stack<GameData> stackGameData)
        {
            Console.WriteLine("\n\n**** STACK VS LIST PERFORMANCE ****\n\n");

            GameData placeholderGameData;

            var watch = Stopwatch.StartNew();
            var lengthOfStack = stackGameData.Count;
            for (var i=0; i<lengthOfStack; i++)
            {
                placeholderGameData = stackGameData.Pop();
            }
            Console.WriteLine($"Measured performance of stack Pop operation with {lengthOfStack} elements: {watch.ElapsedTicks}");
            watch.Restart();

            for (var i = 0; i < lengthOfStack; i++)
            {
                placeholderGameData = listOfGames[listOfGames.Count - 1];
                listOfGames.RemoveAt(listOfGames.Count - 1);
            }
            Console.WriteLine($"Measured performance of List performing Pop operation with {lengthOfStack} elements: {watch.ElapsedTicks}");

            Console.ReadKey();
        }

        static void PerformanceOfQueueVsList(List<GameData> listOfGames, Queue<GameData> queueOfGames)
        {
            Console.WriteLine("\n\n**** QUEUE VS LIST PERFORMANCE ****\n\n");

            GameData placeholderGameData;

            var watch = Stopwatch.StartNew();
            var lengthOfQueue = queueOfGames.Count;
            for (var i = 0; i < lengthOfQueue; i++)
            {
                placeholderGameData = queueOfGames.Dequeue();
            }
            Console.WriteLine($"Measured performance of Queue's Dequeue operation with {lengthOfQueue} elements: {watch.ElapsedTicks}");
            watch.Restart();

            for (var i = 0; i < lengthOfQueue; i++)
            {
                placeholderGameData = listOfGames[0];
                listOfGames.RemoveAt(0);
            }
            Console.WriteLine($"Measured performance of List performing Dequeue operation with {lengthOfQueue} elements: {watch.ElapsedTicks}");

            Console.ReadKey();
        }
    }
}