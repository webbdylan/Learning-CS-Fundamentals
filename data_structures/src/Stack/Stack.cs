using System;
using System.Collections;
using System.Collections.Generic;

namespace ADT
{
    public class Stack<T> : IStack<T>
    {
        private T[] _stack { get; set; }
        private int _lastIndex { get; set; }

        public Stack(int size)
        {
            _stack = new T[size]; 
        }

        public IEnumerator<T> GetEnumerator()
        {
             return (IEnumerator<T>)_stack.GetEnumerator(); 
        }

        public bool IsEmpty()
        {
            return this.Size() > 0 ? false : true;
        }

        public T Peek()
        {
            if(!this.IsEmpty())
            {
                return _stack[_lastIndex -1];
            }
            else
            {
                throw new Exception("Stack is empty- Cannot peek.");
            }
        }

        public T Pop()
        {
            if(!this.IsEmpty())
            {
                var returnItem =  _stack[_lastIndex -1];
                _lastIndex--;
                return returnItem;
            }
            else
            {
                throw new Exception("Stack is null- cannot pop.");
            }
        }

        public void Push(T item)
        {
            if(_stack.Length > _lastIndex)
            {
                _stack[_lastIndex] = item;
                _lastIndex++;
            }
            else
            {
                throw new Exception("Cannot Push- stack is full.");
            }
        }

        public int Size()
        {
            return _lastIndex;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _stack.GetEnumerator();
        }
    }
}
