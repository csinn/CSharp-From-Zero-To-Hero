﻿using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) //ToDo: Implement validation function to make sure it's reusable in other functions as well
            {
                return "N/A.";
            }

            var splitArray = peopleAndBalances[0].Split(',');
            var decimalArray = ConvertStringArrayToDecimalArray(splitArray[1..]);
            var highestValueInArray = FindHighestDecimalInArray(decimalArray);

            return "";
        }

        private static decimal[] ConvertStringArrayToDecimalArray(string[] array)
        {
            var decimalArray = new decimal[array.Length];

            for (int i = 0; i < decimalArray.Length; i++)
            {
                decimalArray[i] = decimal.TryParse(array[i], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed) ? parsed : 0.0m;
            }

            return decimalArray;
        }

        private static decimal FindHighestDecimalInArray(decimal[] array)
        {
            var currentHighestDecimal = array[0]; //We assume the first value to be the largest decimal in the array

            for (int i = 1; i < array.Length; i++)
            {
                if (currentHighestDecimal < array[i])
                {
                    currentHighestDecimal = array[i];
                }
            }

            return currentHighestDecimal;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
        }
    }
}
