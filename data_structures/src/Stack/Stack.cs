using System;
using System.Collections;
using System.Collections.Generic;

namespace ADT
{
    public class Stack<T> : IStack<T>
    {
        private T[] _items { get; set; }
        private int _lastIndex { get; set; }

        public Stack(int size)
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
            if(!IsEmpty())
            {
                return _items[_lastIndex -1];
            }
            else
            {
                throw new Exception("Stack is empty - Cannot peek.");
            }
        }

        public T Pop()
        {
            if(!IsEmpty())
            {
                var itemToReturn = Peek();
                _items[_lastIndex--] = default(T);
                return itemToReturn;
            }
            else
            {
                throw new Exception("Stack is null - cannot pop.");
            }
        }

        public void Push(T item)
        {
            if(_items.Length > _lastIndex)
            {
                _items[_lastIndex++] = item;
            }
            else
            {
                throw new Exception("Cannot Push - stack is full.");
            }
        }

        public int Size()
        {
            return _lastIndex;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
