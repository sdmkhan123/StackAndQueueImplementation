using StackAndQueueImplementation.StackDetailImplementaion;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Welcome to  Stack and Queue");
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("Press 1 : for stack \nPress 0 : to exit");
            int option =Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("Welcome to  Stack");
                    Console.WriteLine("****************************************************************\n");
                    Stack.stackMehtod();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
