using System;
using System.Collections;
using System.Collections.Generic;

namespace ADT
{
    public class DynamicStack<T> : IStack<T>
    {
        private const int MIN_SIZE = 4;
        private T[] _items;
        private int _top;
        public int Capacity => _items.Length;

        public DynamicStack()
        {
            _items = new T[MIN_SIZE];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)_items.GetEnumerator();
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty - Cannot peek.");

            return _items[_top - 1];
        }

        public T Pop()
        {
            if(IsEmpty())
                throw new Exception("Stack is empty - cannot pop.");
                
            if(_top - Capacity > 2 && Capacity != MIN_SIZE)
                Resize();

            return _items[--_top];
        }

        public void Push(T item)
        {
            if(_top + 1 >= Capacity)
                Resize();
                
            _items[_top++] = item;
        }

        public int Size()
        {
            return _top;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        private void Resize()
        {
            //This function needs to resize the items array when called.
            //Calling this function will result in the items array growing or shrinking
            if(Capacity == MIN_SIZE || _top % MIN_SIZE > 2)
            {
                var copy = new T[Capacity + MIN_SIZE];
                _items.CopyTo(copy, 0);
                _items = copy;
            }        
            else
            {
                var copy = new T[Capacity - MIN_SIZE];
                _items.CopyTo(copy, 0);
                _items = copy;
            }   
        }
    }
}
