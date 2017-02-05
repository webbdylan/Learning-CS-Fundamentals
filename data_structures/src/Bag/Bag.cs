using System;
using System.Collections;
using System.Collections.Generic;

namespace ADT
{
    public class Bag<T>: IBag<T>
    {
        private T[] _bag { get; set; }
        private int _fullSpots { get; set; }

        public Bag(int size = 10) { 
            _bag = new T[size];
        }

        public void Add(T item)
        {
            try
            {
                if(_fullSpots == 0)
                {
                    _bag[_fullSpots] = item;   
                }else
                {
                    _bag[_fullSpots] = item;
                }
                _fullSpots++;
            }
            catch(Exception e)
            {
                throw new Exception(e.StackTrace);
            }
        }

        public void Clean()
        {
            var cleaned = 0;

            while(_fullSpots > cleaned)
            {
                _bag[cleaned++] = default(T);
            }

            _fullSpots = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _bag.GetEnumerator() as IEnumerator<T>;
        }

        public bool IsEmpty()
        {
            if(_fullSpots == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public override string ToString()
        {
            var toString = string.Empty;

            for(int length = _fullSpots; length < _fullSpots; length++)
            {
                toString = toString + _bag[length].ToString();
            }

            return toString;
        }

        public int Size()
        {
            return _fullSpots;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<T>)_bag.GetEnumerator();
        }
    }
}
