using System.Collections.Generic;

public interface IBagADT<T> : IEnumerable<T>
{
    //Adds an item to the container
    new void Add(T item);

    //Removes the first matching item from the container
    new void Remove(T item);

    //Removes all items from the container
    void Clean();

    //Checks to see if the container contains any items
    bool IsEmpty();

    //Counts the number of items the container can hold
    int Size();

    //Returns a string representation of all the items in the container
    string Peek();
}