using System;
using System.CodeDom;
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

       
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                   return _items[index];
                }
                throw new ArgumentOutOfRangeException();
            }
            set => _items[index] = value;
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
            if (capacity >= count)
            {
                _items = new T[capacity * 2];
            }
        }

        public void Remove(T item)
        {
            _items[count] = item;
            count--;
        }
    }
}
