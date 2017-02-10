using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public class Bag<T>: IBag<T>
    {
        private readonly T[] _items;
        private readonly int _maxItemCapacity;
        private int _itemCount;

        public Bag(int size = 10)
        {
            _maxItemCapacity = size;
            _items = new T[_maxItemCapacity];
            _itemCount = 0;
        }

        public void Add(T item)
        {
            if (_itemCount >= _maxItemCapacity)
                throw new Exception("Bag is full.");

            _items[_itemCount++] = item;
        }

        public void Clean()
        {
            for (var i = 0; i < _itemCount; i++)
                _items[i] = default(T);

            _itemCount = 0;
        }

        public bool IsEmpty()
        {
            return _itemCount == 0;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in _items)
                sb.AppendLine(item.ToString());

            return sb.ToString();
        }

        public int Size()
        {
            return _itemCount;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)_items.GetEnumerator();
        }
    }
}
