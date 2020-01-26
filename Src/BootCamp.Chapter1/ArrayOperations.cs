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
            if (array != null && array.Length != 0)
            {
                int temp;
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
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
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = temp;
                }
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                var tempArray = new int[array.Length - 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                return tempArray;
            }

            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                var tempArray = new int[array.Length - 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = array[i + 1];
                }
                return tempArray;
            }
            return array;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null)
            {
                return array;
            }
            else if (index < 0 || index >= array.Length)
            {
                return array;
            }
            else
            {
                var tempArray = new int[array.Length - 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (i < index)
                    {
                        tempArray[i] = array[i];
                    }
                    else
                    {
                        tempArray[i] = array[i + 1];
                    }
                }
                return tempArray;
            }
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null)
            {
                var nullableArray = new int[1];
                nullableArray[0] = number;
                return nullableArray;
            }
            else
            {
                var tempArray = new int[array.Length + 1];
                tempArray[0] = number;
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i + 1] = array[i];
                }
                return tempArray;
            }
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null)
            {
                var nullableArray = new int[1];
                nullableArray[0] = number;
                return nullableArray;
            }
            else
            {
                return InsertAt(array, number, array.Length);
            }
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
            if (array == null || index == 0)
            {
                var nullableArray = new int[1];
                nullableArray[0] = number;
                return nullableArray;
            }
            else if (array.Length == 0)
            {
                return array;
            }

            var tempArray = new int[array.Length + 1];
            tempArray[index] = number;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    tempArray[i] = array[i];
                }
                else
                {
                    tempArray[i + 1] = array[i];
                }
            }
            return tempArray;
        }
    }
}