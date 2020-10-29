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
        

        /// <summary>
        /// <paramref name="item"/>
        /// Removes an item
        /// Removes only 1st instances of passing item
        /// Does nothing if item doesn't exsist
        /// If an item removed decrease count by -1 $$
        /// If an item is removed, shift all other items down one
        /// </summary>
        public void Remove(T item)
        {
            bool SomethingHasBeenRemoved = false;
           
            T[] tempArray = new T[Capacity]; // Creating a new array, adding onto the capacity.
            
            for (int i = 0; i < items.Length; i++) // Loop to copy items into the replacement array.
            {
                
                if (EqualityComparer<T>.Default.Equals(item, items[i]))
                {
                    if (SomethingHasBeenRemoved)
                    {
                        tempArray[i] = items[i];
                    }
                    else
                    {
                          SomethingHasBeenRemoved = true;  
                    }
                }
                else
                {
                    tempArray[i] = items[i];  
                }
            }
            items = tempArray; // Replacing the old array with the new array.
           
            if (SomethingHasBeenRemoved)
            {
                 Count--;  
            }
        }
    }
}
