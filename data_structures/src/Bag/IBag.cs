using System.Collections.Generic;

namespace ADT
{
    public interface IBag<T> : IEnumerable<T>
    {
        //Adds an item to the container
        void Add(T item);

        //Removes all items from the container
        void Clean();

        //Checks to see if the container contains any items
        bool IsEmpty();

        //Counts the number of items in the container
        int Size();

        //Returns a string representation of all the items in the container
        string ToString();
    }
}
