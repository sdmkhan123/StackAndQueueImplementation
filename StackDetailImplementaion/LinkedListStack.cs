using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation.StackDetailImplementaion
{
    public class LinkedListStack<Gtype>
    {
        //initialize the head of the LL
        internal NodeCreation<Gtype> top;
        /// <summary>
        /// push a new node into stack i.e. add a node in front of LL
        /// </summary>
        /// <param name="value"></param>
        public void push(Gtype value)
        {
            //Create a new Node of LL and add to LL
            NodeCreation<Gtype> stackNode = new NodeCreation<Gtype>(value);
            if (top == null)
            {
                this.top = stackNode;
            }
            else
            {
                stackNode.next = this.top;
                top = stackNode;
            }
        }
        public Gtype peek()
        {
            NodeCreation<Gtype> temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Given stack is empty");
                return temp.data;
            }
            else
            {
                return temp.data;
            }

        }
        /// <summary>
        /// display the all the data in Current stack
        /// </summary>
        public void displayLL()
        {
            NodeCreation<Gtype> temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Given stack is empty");
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Display all the value of stack");
            Console.WriteLine("****************************************************************");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
