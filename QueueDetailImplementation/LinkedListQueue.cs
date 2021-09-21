using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation.QueueDetailImplementation
{
    public class LinkedListQueue<Gtype>
    {
        //initialize the head of the LL
        internal NodeCreation<Gtype> frontNode, rearNode;
        public void enQueue(Gtype value)
        {
            NodeCreation<Gtype> queuekNode = new NodeCreation<Gtype>(value);
            if (this.rearNode == null)
            {
                this.frontNode = queuekNode;
                this.rearNode = queuekNode;
            }
            else
            {
                this.rearNode.next = queuekNode;
                this.rearNode = queuekNode;
            }

        }
        public void displayLL()
        {
            NodeCreation<Gtype> temp = frontNode;
            if (temp == null)
            {
                Console.WriteLine("Given queue is empty");
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Display all the value of queue");
            Console.WriteLine("****************************************************************");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
        public Gtype deQueue()
        {

            if (this.frontNode == null)
            {
                Console.WriteLine("Queue is empty");
                return frontNode.data;
            }
            else
            {
                NodeCreation<Gtype> temp = frontNode;
                this.frontNode = frontNode.next;
                return temp.data;
            }
            if (frontNode == null)
            {
                this.rearNode = null;
            }

        }
    }
}