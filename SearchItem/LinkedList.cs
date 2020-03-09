using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.ListaEnlazada
{
    public class LinkedList
    {
        private Node head;
        private Node tail;

        public Node Head
        {
            get
            {
                return this.head;
            }
        }

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void AddItemAtBeginning(int value)
        {
            Node node = new Node(value);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.Next = this.head;
                this.head = node;
            }
        }

        public void AddItemAtEnd(int value)
        {
            Node node = new Node(value);
            if (this.head == null)
            {
                this.head = this.tail = node;
            }
            else
            {
                this.tail.Next = node;
                this.tail = node;
            }
        }

        public void RemoveItem(int item)
        {
            Node node = this.head;
            if (node != null && node.Value == item)
            {
                this.head = this.head.Next;
            }
            else
            {
                node = this.SearchPreviousNode(item);
                if (node != null)
                {
                    node.Next = node.Next?.Next;
                }
            }
        }

        public Node RemoveFirstItem()
        {
            Node node = this.head;
            this.head = this.head?.Next;
            return node;
        }

        public Node SearchItem(int item)
        {
            Node node = this.head;
            while (node != null)
            {
                if (node.Value == item)
                {
                    return node;
                }
                node = node.Next;
            }
            return null;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        private Node SearchPreviousNode(int item)
        {
            Node node = this.head;
            while (node != null)
            {
                if (node.Next?.Value == item)
                {
                    return node;
                }
                node = node.Next;
            }
            return null;
        }
    }
}
