using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson3_1
{
    public class Node<T>
    {
        public Node(T element)
        {
            Element = element;
        }
        public T Element { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }

    }

    public class CustomList<T> : IEnumerable<T>, ICustomList<T>
    {
        Node<T> Head; //link on first element
        Node<T> Tail; //link on Last element
        public Notebook this[int index] => throw new NotImplementedException();
        int count;

        public void Add(T value)
        {
            Node<T> NodeValue = new Node<T>(value);

            if (Head == null)
            {
                Head = NodeValue;
            }
            else
            {
                Tail.Next = NodeValue;
                NodeValue.Previous = Tail;
            }
            Tail = NodeValue;
            count++;
        }

        public bool Delete(T value)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Element.Equals(value))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    Tail = current.Previous;
                }
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    Head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        public int Count { get { return count; } }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }
    }

    
    public class Notebook
    {
        public Notebook(int serialNumber, string name)
        {
            SerialNumber = serialNumber;
            Name = name;
        }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
    }

}

//var notebookCollectin = new CustomList();
//var igor = new NoteBook(1, "Igor");
//var vasia = new Note
