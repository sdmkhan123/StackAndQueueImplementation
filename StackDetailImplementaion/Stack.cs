using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation.StackDetailImplementaion
{
    public class Stack
    {
        public static void stackMehtod()
        {
            //Object of class LinkedListStack
            LinkedListStack<int> stack = new LinkedListStack<int>();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            Console.WriteLine("After pushing some node into stack");
            stack.displayLL();
            Console.WriteLine("\n****************************************************************");
            //Find the Top most element of the stack i.e. Peek
            int peekValue = stack.peek();
            Console.WriteLine("Peek value of stack is " + peekValue);
            stack.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Pop the element from the stack one by one till satck empty
            Console.WriteLine("Pop value of stack are ");
            stack.pop();
            Console.WriteLine("\n****************************************************************");
        }
    }
}
