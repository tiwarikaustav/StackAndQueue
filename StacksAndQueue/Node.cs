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
    /// <summary>
    /// Building block of Linked List
    /// </summary>
    /// <typeparam name="int">The type of the nt.</typeparam>
    public class Node
    {
        /// <summary>
        /// The data
        /// </summary>
        public int data;

        /// <summary>
        /// The next Node
        /// </summary>
        public Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{int}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
