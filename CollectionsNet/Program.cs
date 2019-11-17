using System;
using System.Collections;

namespace CollectionsNet_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            StackAndQueue();
        }

        static void StackAndQueue()
        {
            var dataToPlayWith = new string[] { "1st Element", "2nd Element", "3rd Element", "4th Element", "5th Element", "6th Element" };

            Console.WriteLine("*****STACK******\n\n");
            StackIntroduction(dataToPlayWith);
            Console.WriteLine("\n\n*****QUEUE******\n\n");
            QueueIntroduction(dataToPlayWith);
        }

        #region StackIntroduction
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
        #endregion StackIntroduction

        #region QueueIntroduction
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
        #endregion QueueIntroduction
    }
}
