using StackAndQueueImplementation.StackDetailImplementaion;
using StackAndQueueImplementation.QueueDetailImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation
{
    internal class NodeCreation<Gtype>
    {
        //intilize instance variable of class
        internal NodeCreation<Gtype> next;
        internal Gtype data;
        /// <summary>
        /// constructor called to create a node
        /// </summary>
        /// <param name="value"></param>
        internal NodeCreation(Gtype value)
        {
            this.data = value;
        }
    }
}