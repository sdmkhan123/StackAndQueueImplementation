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
            Console.WriteLine("****************************************************************");
            //Object of class LinkedListStack
            LinkedListStack<int> stack = new LinkedListStack<int>();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            Console.WriteLine("After pushing some node into stack");
            stack.displayLL();
        }
    }
}
