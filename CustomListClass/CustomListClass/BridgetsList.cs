using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomList
{
    public class BridgetsList<T>
    {
        //member variable

        
        private int count;
        private int capacity;

        private T[] _items;

        public int Count 
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        int[] bridgetslist = new int[10]
        {
            1, 2, 3, 4, 5,
            6, 7, 8, 9, 10
        };

        public int length => bridgetslist.Length;

        public int this[int index]
        {
            get => bridgetslist[index];
            set => bridgetslist[index] = value;
         }

        ////constructor
        public BridgetsList()
        {

            count = 0;
            capacity = 4;
            _items = new T[capacity];

        }

        //member methods
        public void Add(T item)
        {
            _items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            _items[count] = item;
            count--;
        }
    }
}
