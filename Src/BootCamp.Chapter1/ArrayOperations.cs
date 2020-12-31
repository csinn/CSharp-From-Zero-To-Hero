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

            int tempElement;
            for (int iOne = 0; iOne < array.Length - 1; iOne++)
            {
                for (int iTwo = iOne + 1; iTwo < array.Length; iTwo++)
                {
                    if (array[iTwo] < array[iOne])
                    {
                        tempElement = array[iOne];
                        array[iOne] = array[iTwo];
                        array[iTwo] = tempElement;
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
                int tempElement;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    tempElement = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = tempElement;
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
            if (array == null || array.Length == 0)
            {
                return array;
            }
            return RemoveAt(array, array.Length - 1);
            /* var new_array = new int[array.Length - 1];
             for (int i = 0; i < array.Length - 1; i++)
             {
                 new_array[i] = array[i];
             }
             return new_array;*/
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
            return RemoveAt(array, 0);
            /*var new_array = new int[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
            {
                new_array[i - 1] = array[i];
            }
            return new_array;*/
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            if (index >= array.Length || index < 0)
            {
                return array;
            }

            var new_array = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i < index)
                {
                    new_array[i] = array[i];
                }
                else
                {
                    new_array[i] = array[i + 1];
                }
            }
            return new_array;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                return new int[] { number };
                //return array;
            }
            return InsertAt(array, number, 0);
            /* var new_array = new int[array.Length + 1];
             new_array[0] = number;
             for (int i = 0; i < array.Length; i++)
             {
                 new_array[i + 1] = array[i];
             }
             return new_array;*/
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0)
            {
                return new int[] { number };
                //return array;
            }
            return InsertAt(array, number, array.Length);
            /* var new_array = new int[array.Length + 1];
             new_array[array.Length] = number;
             for (int i = 0; i < array.Length; i++)
             {
                 new_array[i] = array[i];
             }
             return new_array;*/
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
            if (array == null || array.Length == 0)
            {
                if (index == 0)
                {
                    array = new int[] { number };
                    return array;

                }
                else
                {
                    return array;
                }
            }

            if (index >= array.Length || index < 0)
            {
                return array;
            }

            var new_array = new int[array.Length + 1];
            new_array[index] = number;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    new_array[i] = array[i];
                }
                else
                {
                    new_array[i + 1] = array[i];
                }
            }
            return new_array;
        }
    }
}
