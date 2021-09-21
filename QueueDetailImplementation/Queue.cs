using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation.QueueDetailImplementation
{
    public class Queue
    {
        public static void queueMehtod()
        {
            //Create an object of LinkedListQueue class
            LinkedListQueue<int> queue = new LinkedListQueue<int>();
            queue.enQueue(56);
            queue.enQueue(30);
            queue.enQueue(70);
            Console.WriteLine("After enqueue some node into queue");
            queue.displayLL();
            Console.WriteLine("\n****************************************************************");
            int value = queue.deQueue();
            Console.WriteLine("After Dequeue node into queue");
            Console.WriteLine("Dequeue value is " + value);
            queue.displayLL();
            Console.WriteLine("****************************************************************");
        }
    }
}