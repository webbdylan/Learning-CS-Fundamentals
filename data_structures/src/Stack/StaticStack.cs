using System;
using System.Collections;
using System.Collections.Generic;

namespace ADT
{
    public class StaticStack<T> : IStack<T>
    {
        private readonly T[] _items;
        private int _top;
        private int _itemCount;

        public StaticStack(int size = 5)
        {
            _items = new T[size];
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
            if(IsEmpty())
                throw new Exception("Stack is empty - Cannot peek.");

            return _items[_top - 1];
        }

        public T Pop()
        {
            if(IsEmpty())
                throw new Exception("Stack is null - cannot pop.");

            var itemToReturn = Peek();

            _items[_top--] = default(T);
            _itemCount--;

            return itemToReturn;
        }

        public void Push(T item)
        {
            if(Size() >= _items.Length)
                throw new Exception("Cannot Push - stack is full.");

            _items[_top++] = item;
            _itemCount++;
        }

        public int Size()
        {
            return _itemCount;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
