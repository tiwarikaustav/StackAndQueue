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
    class Stack
    {
        /// <summary>
        /// The linked list
        /// </summary>
        LinkedList linkedList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack{int}"/> class.
        /// </summary>
        public Stack()
        {
            linkedList = new LinkedList();
        }

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(int data)
        {
            linkedList.PushFront(data);
        }

        /// <summary>
        /// Traverses this instance.
        /// </summary>
        public void Traverse()
        {
            linkedList.Traverse();
        }

        /// <summary>
        /// Peeks from top
        /// </summary>
        /// <returns>T Generic type</returns>
        public int Peak()
        {
            return this.linkedList.head.data;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        public void Pop()
        {
            this.linkedList.PopFront();
        }
    }
}
