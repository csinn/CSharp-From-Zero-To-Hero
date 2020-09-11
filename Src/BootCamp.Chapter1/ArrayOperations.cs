﻿using System;

namespace BootCamp.Chapter1
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

            Array.Sort(array);
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

            Array.Reverse(array);
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            var newLength = array.Length - 1;
            var newArray = new int[newLength];

            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }

            var newLength = array.Length - 1;
            var newArray = new int[newLength];

            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = array[i+1];
            }

            return newArray;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0 
                || index > array.Length - 1 || index < 0)
            {
                return array;
            }

            var newLength = array.Length - 1;
            var newArray = new int[newLength];
          

            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = i >= index ? array[i+1] : array[i];
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
            var newLength = array == null ? 1 : array.Length + 1;
            var newArray = new int[newLength];
            newArray[0] = number;

            if (array == null || array.Length == 0)
            {
                return newArray;
            }

            for (int i = 1; i < newLength; i++)
            {
                newArray[i] = array[i - 1];
            }

            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            var newLength = array == null ? 1 : array.Length + 1;
            var newArray = new int[newLength];
            newArray[newLength - 1] = number;

            if (array == null || array.Length == 0)
            {
                return newArray;
            }

            for (int i = 0; i < newLength -1; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
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
            var newLength = array == null ? 1 : array.Length + 1;

            // If index is out of range
            if (index >= newLength || index < 0)
            {
                return array;
            }

            var newArray = new int[newLength];
            newArray[index] = number;

            if (array == null || array.Length == 0)
            {
                return newArray;
            }

            for (int i = 0; i < newLength -1; i++)
            {
                if (i < index)
                {
                    newArray[i] = array[i];
                }

                if (i > index)
                {
                    newArray[i+1] = array[i];
                }
            }

            return newArray;
        }
    }
}
