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
        private int _itemCount;
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

            return _items[_top];
        }

        public T Pop()
        {
            //You will need to have logic here to determine if the array needs to shrink
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            //You will need to have logic here to determine if the array needs to grow
            throw new NotImplementedException();
        }

        public int Size()
        {
            return _itemCount;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        private void Resize()
        {
            //This function needs to resize the items array when called.
            //Calling this function will result in the items array growing or shrinking
        }
    }
}
