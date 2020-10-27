using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListUnitTestStarter
{
    public class CustomList<T>
    {

        private T[] items;
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
    }
}
