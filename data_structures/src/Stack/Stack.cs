using System;
using System.Collections;
using System.Collections.Generic;

namespace ADT
{
    public class Stack<T> : IStack<T>
    {
        private T[] _stack { get; set; }

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
                return _stack[0];
            }
            else
            {
                throw new Exception("Stack is empty- Cannot peek.");
            }
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return _stack.Length;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _stack.GetEnumerator();
        }
    }
}
