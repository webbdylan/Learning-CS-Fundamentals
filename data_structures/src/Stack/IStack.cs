using System.Collections.Generic;

namespace ADT
{
    public interface IStack<T> : IEnumerable<T>
    {
        //Adds an item to the container
        void Push(T item);

        //Removes and returns the item on the top of the stack
        T Pop();

        //Returns the item on the top of the stack
        T Peek();

        //Checks to see if the container contains any items
        bool IsEmpty();

        //Counts the number of items in the container
        int Size();
    }
}
