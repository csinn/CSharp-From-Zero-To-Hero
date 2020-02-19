﻿namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength / 2; i++)
            {

                int temp = array[i];
                array[i] = array[arrayLength - i - 1];
                array[arrayLength - i - 1] = temp;
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array != null)
            {
                return RemoveItemFromIndex(array, array.Length - 1);
            }
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            return RemoveItemFromIndex(array, 0);
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            return RemoveItemFromIndex(array, index);
        }
        public static int[] RemoveItemFromIndex(int[] array, int index)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            if (index < 0 || index >= array.Length)
            {
                return array;
            }

            int arrayLength = array.Length - 1;
            int[] newArray = new int[arrayLength];
            int removedIndex = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                if (i == index)
                {
                    removedIndex = 1;
                }
                newArray[i] = array[i + removedIndex];
            }
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            return InsertItemToIndex(array, number, 0);
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            int arrayLength = 0;
            if (array != null)
            {
                arrayLength = array.Length;
            }
            return InsertItemToIndex(array, number, arrayLength);
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            return InsertItemToIndex(array, number, index);
        }

        public static int[] InsertItemToIndex(int[] array, int number, int index)
        {

            if (array == null || array.Length == 0)
            {
                if (array != null && array.Length == 0 && index != 0)
                {
                    return array;
                }
                int[] newArrayWithOneItem = new int[] { number };
                return newArrayWithOneItem;
            }

            int arrayLength = array.Length;
            if (index < 0 || index > arrayLength)
            {
                return array;
            }
            int[] newArray = new int[arrayLength + 1];
            int newArrayLength = newArray.Length;
            int additionalIndex = 0;
            for (int i = 0; i < newArrayLength; i++)
            {
                if (i == index)
                {
                    newArray[i] = number;
                    additionalIndex = 1;
                }
                else
                {
                    newArray[i] = array[i - additionalIndex];
                }
            }
            return newArray;
        }
    }
}
