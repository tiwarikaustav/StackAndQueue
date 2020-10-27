// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aryav Tiwari "/>
//
using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    class Queue
    {
        /// <summary>
        /// The linked list
        /// </summary>
        LinkedList linkedList;

        /// <summary>
        /// Initializes a new instance of the Queue class.
        /// </summary>
        public Queue()
        {
            this.linkedList = new LinkedList();
        }

        /// <summary>
        /// Enqueus the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueu(int data)
        {
            linkedList.PushBack(data);
        }

        /// <summary>
        /// Traverses this instance.
        /// </summary>
        public void Traverse()
        {
            this.linkedList.Traverse();
        }
    }
}
