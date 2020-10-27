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
        /// LinkedList Class
        /// </summary>
        /// <typeparam</typeparam>
        public class LinkedList
        {
            /// <summary>
            /// The head Node
            /// </summary>
            public Node head;

            /// <summary>
            /// The tail Node
            /// </summary>
            public Node tail;

            /// <summary>
            /// Initializes a new instance of the <see cref="LinkedList{T}"/> class.
            /// </summary>
            public LinkedList()
            {
                this.head = null;
                this.tail = this.head;
            }

            /// <summary>
            /// Pushes the Node at the back of LinkedList.
            /// </summary>
            /// <param name="data">The data.</param>
            public void PushBack(int data)
            {
                if (this.head == null)
                {
                    this.head = new Node(data);
                    this.tail = this.head;
                    return;
                }

                Node temp = new Node(data);
                this.tail.next = temp;
                this.tail = temp;
            }

            /// <summary>
            /// Pushes the Node at the front of LinkedList.
            /// </summary>
            /// <param name="data">The data.</param>
            public void PushFront(int data)
            {
                if (this.head == null)
                {
                    this.head = new Node(data);
                    this.tail = this.head;
                    return;
                }

                Node temp = new Node(data);
                temp.next = this.head;
                this.head = temp;
            }

            /// <summary>
            /// Pushes Node at given index.
            /// </summary>
            /// <param name="index">The index.</param>
            /// <param name="data">The data.</param>
            public void PushAtIndex(int index, int data)
            {
                if (this.head == null)
                {
                    this.head = new Node(data);
                    this.tail = this.head;
                    return;
                }
                if (index == 0)
                {
                    PushFront(data);
                    return;
                }
                Node node = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    node = node.next;
                }

                Node temp = new Node(data);
                temp.next = node.next;
                node.next = temp;
            }

            /// <summary>
            /// Delete the front Node.
            /// </summary>
            public void PopFront()
            {
                if (this.head == null)
                {
                    return;
                }

                this.head = this.head.next;
            }

            /// <summary>
            /// Counts number of Nodes.
            /// </summary>
            /// <returns></returns>
            public int Count()
            {
                int count = 0;
                Node node = head;
                while (node != null)
                {
                    node = node.next;
                    count++;
                }
                return count;
            }

            /// <summary>
            /// Delete the Node at end.
            /// </summary>
            public void PopBack()
            {
                if (this.head == null)
                {
                    return;
                }

                Node node = head;
                int length = Count();
                if (length <= 1)
                {
                    this.head = null;
                    this.tail = this.head;
                    return;
                }
                for (int i = 1; i < length - 1; i++)
                {
                    node = node.next;
                }
                node.next = null;
                tail = node;
            }

            /// <summary>
            /// Pops the node from given index.
            /// </summary>
            /// <param name="index">The index.</param>
            public void PopFromGivenIndex(int index)
            {
                if (this.head == null)
                {
                    return;
                }

                Node node = head;
                int length = Count();
                if (index >= length || index < 0)
                {
                    Console.WriteLine("Invalid index for pop operation!");
                    return;
                }
                if (index == 0)
                {
                    PopFront();
                    return;
                }
                if (index == length - 1)
                {
                    PopBack();
                    return;
                }
                for (int i = 1; i < index; i++)
                {
                    node = node.next;
                }
                node.next = node.next.next;
            }

            /// <summary>
            /// Traverses this instance.
            /// </summary>
            public void Traverse()
            {
                Node temp = this.head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }

                Console.WriteLine();
            }

            /// <summary>
            /// Searches the specified data.
            /// </summary>
            /// <param name="data">The data.</param>
            /// <returns></returns>
            public int Search(int data)
            {
                Node temp = this.head;
                int index = 0;
                while (temp != null)
                {
                    if (temp.data.Equals(data))
                    {
                        return index;
                    }
                    temp = temp.next;
                    index++;
                }
                return -1;
            }

            /// <summary>
            /// Pushes in ascending order.
            /// </summary>
            /// <param name="data">The data.</param>
            public void PushInAscendingOrder(int data)
            {
                if (this.head == null)
                {
                    this.head = new Node(data);
                    this.tail = this.head;
                    return;
                }
                Node node = new Node(data);
                if (node.data.CompareTo(this.head.data) < 0)
                {
                    PushFront(data);
                    return;
                }
                Node temp = this.head;
                while (temp.data.CompareTo(data) < 0 && temp.next != null && temp.next.data.CompareTo(data) < 0)
                {
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
}
