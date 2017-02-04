using System;
using System.Collections;
using System.Collections.Generic;

public class BagADT<T>: IBagADT<T>
{
    public BagADT(int size = 10) { }

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clean()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        throw new NotImplementedException();
    }

    public string Peek()
    {
        throw new NotImplementedException();
    }

    public int Size()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
