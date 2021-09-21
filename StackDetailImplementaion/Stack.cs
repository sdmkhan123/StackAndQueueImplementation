using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation.StackDetailImplementaion
{
    class Stack
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
            //Find the Top most element of the stack i.e. Peek
            Console.WriteLine("\n****************************************************************");
            int peekValue = stack.peek();
            Console.WriteLine("Peek value of stack is " + peekValue);
            Console.WriteLine("\n****************************************************************");
        }
    }
}
