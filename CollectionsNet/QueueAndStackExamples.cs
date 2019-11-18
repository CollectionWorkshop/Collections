using CollectionsNet_Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CollectionsNet
{
    public static class QueueAndStackExamples
    {
        public static void StackAndQueueIntroduction()
        {
            var dataToPlayWith = new string[] { "1st Element", "2nd Element", "3rd Element", "4th Element", "5th Element", "6th Element" };

            Console.WriteLine("*****STACK******\n\n");
            StackIntroduction(dataToPlayWith);

            Console.WriteLine("\n\n*****QUEUE******\n\n");
            QueueIntroduction(dataToPlayWith);

        }

        public static void StackQueuePerformance(IEnumerable<GameData> footballData)
        {

            Stack<GameData> footballDataStack = new Stack<GameData>(footballData); // convert to Stack
            PerformanceStackVsList(footballData.ToList(), footballDataStack);

            Queue<GameData> footballDataQueue = new Queue<GameData>(footballData); // convert to Queue
            PerformanceOfQueueVsList(footballData.ToList(), footballDataQueue);
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

        static void StackIntroduction(string[] dataToPlayWith)
        {
            var stackExample = new Stack();

            foreach (var element in dataToPlayWith)
            {
                stackExample.Push(element);
            }

            Console.WriteLine($"Total number of elements in the Stack is: {stackExample.Count}");

            Console.WriteLine($"\nStack's peek method: {stackExample.Peek()}");
            Console.WriteLine($"Total number of elements in the Stack after using PEEK method: {stackExample.Count}");

            Console.WriteLine($"\nStack's pop method: {stackExample.Pop()}");
            Console.WriteLine($"Total number of elements in the Stack after using POP method: {stackExample.Count}");

            Console.WriteLine("\nLet's take one more element from stack");
            Console.WriteLine($"Stack's pop method: {stackExample.Pop()}");
            Console.WriteLine($"Total number of elements in the Stack after using POP method for the second time: {stackExample.Count}");

            Console.WriteLine("\nLet's clear all the elements from the stack");
            stackExample.Clear();
            Console.WriteLine($"Total number of elements in the Stack after using Clear: {stackExample.Count}");

            try
            {
                Console.WriteLine("Let's try to use PEEK method on empty stack");
                stackExample.Peek();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}");
            }

            Console.ReadKey();
        }

        static void QueueIntroduction(string[] dataToPlayWith)
        {
            var queueExample = new Queue();

            foreach (var element in dataToPlayWith)
            {
                queueExample.Enqueue(element);
            }

            Console.WriteLine($"Total number of elements in the Queue is: {queueExample.Count}");

            Console.WriteLine($"\nQueue's peek method: {queueExample.Peek()}");
            Console.WriteLine($"Total number of elements in the Queue after using PEEK method: {queueExample.Count}");

            Console.WriteLine($"\nQueue's dequeue method: {queueExample.Dequeue()}");
            Console.WriteLine($"Total number of elements in the Queue after using DEQUEUE method: {queueExample.Count}");

            Console.WriteLine("\nLet's take one more element from queue");
            Console.WriteLine($"Queue's dequeue method: {queueExample.Dequeue()}");
            Console.WriteLine($"Total number of elements in the Queue after using DEQUEUE method for the second time: {queueExample.Count}");

            Console.WriteLine("\nLet's clear all the elements from the queue");
            queueExample.Clear();
            Console.WriteLine($"Total number of elements in the Queue after using Clear: {queueExample.Count}");

            try
            {
                Console.WriteLine("Let's try to use PEEK method on empty Queue");
                queueExample.Peek();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}

 
//https://stackoverflow.com/questions/2074970/stack-and-queue-why

//https://www.geeksforgeeks.org/reverse-level-order-traversal/