﻿using System;
using System.Buffers;
using System.Linq;

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
            if ((array == null) || (array.Length == 0))
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
            if ((array == null) || (array.Length == 0))
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
            if (array == null)
            {
                return null;
            }
            else if (array.Length == 0)
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i <= newArray.Length - 1; i++)
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
            if (array == null)
            {
                return null;
            }
            else if (array.Length == 0)
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];
            for (int i = 1; i <= newArray.Length; i++)
            {
                newArray[i - 1] = array[i];
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
            if (array == null)
            {
                return null;
            }
            else if (array.Length == 0)
            {
                return array;
            }

            if ((index < 0) || (index > array.Length))
            {
                return array;
            }

            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i <= newArray.Length - 1; i++)
            {
                if (i != index)
                {
                    newArray[i] = array[i];
                }
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
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            // ToDo: implement.
            return array;
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
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i < index - 1)
                {
                    newArray[i] = array[i];
                }
                else if (i == index - 1)
                {
                    newArray[i] = number;
                }
                else
                {
                    newArray[i] = array[i - 1];
                }
            }
            return newArray;
        }
    }
}
