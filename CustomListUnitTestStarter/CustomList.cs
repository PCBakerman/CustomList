using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListUnitTestStarter
{
    public class CustomList<T>
    {

        private T[] items;

        // Indexer with only a get accessor with the expression-bodied definition:(From https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers)
        public T this[int index] => FindItemByIndex(index);
        public int Capacity { get { return items.Length; } }
        public int Count { get; private set; }
        public CustomList()
        {
            Count = 0;
            items = new T[4];
        }
        public void Add(T item) 
        {
            // Check if we need to expand the array.
            if (Count + 1 >= Capacity) 
            {
                T[] tempArray = new T[Capacity * 2]; // Creating a new array, adding onto the capacity.
                for (int i = 0; i < items.Length; i++) // Loop to copy items into the replacement array.
                {
                    tempArray[i] = items[i];
                }
                items = tempArray; // Replacing the old array with the new array.
            }
            items[Count] = item; // Set item into items array at the count index.
            Count++;  // Add one to the count
        }
      
        private T FindItemByIndex(int index)
        {
            
            // Check if index is within our array.
            if (index >= Count)
            {
                // Index is bigger than our items in the array.
                throw new ArgumentOutOfRangeException(
                 $"Index out of range.");

            }
             //Return item at index.
             return items[index];


        }
        public void Remove(T item)
        {
            // Check if we need to expand the array.
            if (Count - 1 >= Capacity)
            {
                T[] tempArray = new T[Capacity * 2]; // Creating a new array, adding onto the capacity.
                for (int i = 0; i < items.Length; i--) // Loop to copy items into the replacement array.
                {
                    tempArray[i] = items[i];
                }
                items = tempArray; // Replacing the old array with the new array.
            }
            items[Count] = item; // Set item into items array at the count index.
            Count--;  // Remove one to the count.
        }
    }
}
