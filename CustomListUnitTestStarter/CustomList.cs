using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListUnitTestStarter
{
    public class CustomList<T> : IEnumerable
    {

        private T[] items;

        // Indexer with only a get accessors with the expression-bodied definition:(From https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers)
        public T this[int index] => FindItemByIndex(index);
        public int Capacity { get; set; }
        public int Count { get; private set; }
        public CustomList()
        {
            Capacity = 4;
            Count = 0;
            items = new T[Capacity];
        }
        public void Add(T item)
        {
            // Check if we need to expand the array.
            if (Count + 1 >= Capacity)
            {
                Capacity = Capacity * 2;
                T[] tempArray = new T[Capacity]; // Creating a new array, adding onto the capacity.
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
            if (index < 0 || index >= Count)
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
        public override string ToString()
        {
            var result = string.Empty;
            for (var i = 0; i < Count; i++)
            {
                result += items[i].ToString();
            }
            return result;
        }
        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            var result = new CustomList<T>();
            if (a == null || b == null)
            {
                throw new ArgumentNullException();
            }
            for (var i = 0; i < a.Count; i++)
            {
                result.Add(a[i]);
            }
            for (var i = 0; i < b.Count; i++)
            {
                result.Add(b[i]);
            }
            return result;
        }
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException();
            }
            var result = a;
            for (var i = 0; i < b.Count; i++)
            {
                result.Remove(b[i]);
            }
            return result;

        }

        public CustomList<T> Zip(CustomList<T> customList) 
        {
            if(customList == null)
            {
                throw new ArgumentNullException();
            }
            var result = new CustomList<T>();
            var max = Count >= customList.Count ? Count : customList.Count;
            for (var i = 0; i < max; i++)
            {
                result.Add(items[i]);
                if(i < customList.Count)
                {
                    result.Add(customList[i]);
                }
            }
            return result;
     
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public CustomListEnumerator<T> GetEnumerator()
        {
            return new CustomListEnumerator<T> (items, Count);
        } 
    }
}


