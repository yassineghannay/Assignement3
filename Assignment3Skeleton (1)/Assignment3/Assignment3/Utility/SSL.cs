using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//testcommitfromvs
//testcomitfinal
namespace Assignment3.Utility
{

        // exception thrown when an operation to remove an element from the linked list cannot be performed
    public class CannotRemoveException : Exception
    {
        public CannotRemoveException() : base() { }

        public CannotRemoveException(string message) : base(message) { }

        public CannotRemoveException(string message, Exception innerException) : base(message, innerException) { }
    }

     class SSL : ILinkedListADT
    {
        private Node head;
        private int listSize;

        public SSL()
        {
            head = null;
            listSize = 0;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Clear()
        {
            head = null;
            listSize = 0;
        }

        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            listSize++;
        }

        public void AddLast(User value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            listSize++;
        }

        public void Add(User value, int index)
        {
            if (index < 0 || index > listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            if (index == 0)
            {
                AddFirst(value);
            }
            else if (index == listSize)
            {
                AddLast(value);
            }
            else
            {
                Node newNode = new Node(value);
                Node prevNode = GetNodeAtIndex(index - 1);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
                listSize++;
            }
        }

        public void Replace(User value, int index)
        {
            Node node = GetNodeAtIndex(index);
            node.Value = value;
        }

        public int Count()
        {
            return listSize;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new CannotRemoveException("List is empty.");
            }
            head = head.Next;
            listSize--;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                throw new CannotRemoveException("List is empty.");
            }
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            listSize--;
        }

       public void Remove(int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            if (index == 0)
            {
                RemoveFirst();
            }
            else
            {
                Node prevNode = GetNodeAtIndex(index - 1);
                prevNode.Next = prevNode.Next.Next;
                listSize--;
            }
        }

        public User GetValue(int index)
        {
            return GetNodeAtIndex(index).Value;
        }

        public int IndexOf(User value)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        }

        private Node GetNodeAtIndex(int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }
    }
}

//The class has methods for common linked list operations such as adding elements to the beginning and end of the list (AddFirst, AddLast), adding an element at a specific index (Add), removing elements from the beginning and end of the list (RemoveFirst, RemoveLast), removing an element at a specific index (Remove), retrieving the value at a specific index (GetValue), finding the index of a specific value (IndexOf), and checking if a value exists in the list (Contains).
