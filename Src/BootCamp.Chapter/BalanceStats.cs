﻿using System;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            var splitArray = peopleAndBalances[0].Split(',');
            var floatArray = ConvertStringArrayToFloatArray(splitArray[1..]);
            var names = new[] { splitArray[0] };
            var heighestBalance = FindHighestBalance(floatArray);

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currrentSplitArray = peopleAndBalances[i].Split(',');
                var currentFloatArray = ConvertStringArrayToFloatArray(currrentSplitArray[1..]);
                var name = currrentSplitArray[0];
                var currentHeighest = FindHighestBalance(currentFloatArray);

                if (currentHeighest > heighestBalance)
                {
                    heighestBalance = currentHeighest;
                    names = new[] { name };
                }
                else if (currentHeighest == heighestBalance)
                {
                    names = AddString(names, name);
                }
            }

            return $"{FormatStrings(names)} had the most money ever. ¤{heighestBalance}.";
        }

        private static float FindHighestBalance(float[] floatArray)
        {
            float currentMax = floatArray[0];
            for (int i = 1; i < floatArray.Length; i++)
            {
                if (floatArray[i] > currentMax)
                {
                    currentMax = floatArray[i];
                }
            }
            return currentMax;
        }

        private static float[] ConvertStringArrayToFloatArray(string[] v)
        {
            var arr = new float[v.Length];

            for (int i = 0; i < v.Length; i++)
            {
                arr[i] = float.TryParse(v[i], out float parsed) ? parsed : 0f;
            }
            return arr;
        }

        private static string FormatStrings(string[] currentNames)
        {
            if (currentNames.Length == 1)
            {
                return currentNames[0];
            }
            var formatArray = String.Join(", ", currentNames[..^1]);
            formatArray += $" and {currentNames[^1]}";

            return formatArray;
        }

        private static string[] AddString(string[] currentNames, string v)
        {
            var newArray = new string[currentNames.Length + 1];
            for (int i = 0; i < currentNames.Length; i++)
            {
                newArray[i] = currentNames[i];
            }
            newArray[^1] = v;

            return newArray;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            string[] splitArray;
            float[] floatArray;
            int firstIndex = 0;

            do
            {
                splitArray = peopleAndBalances[firstIndex].Split(',');
                floatArray = ConvertStringArrayToFloatArray(splitArray[1..]);
                firstIndex++;

            } while (floatArray.Length < 2 && firstIndex < peopleAndBalances.Length);


            if (peopleAndBalances.Length == firstIndex && floatArray.Length < 2)
            {
                return "N/A.";
            }

            var names = new[] { splitArray[0] };
            var biggestLoss = FindHighestBalance(floatArray) - FindLowestBalance(floatArray);

            for (int i = firstIndex; i < peopleAndBalances.Length; i++)
            {
                var currentSplitArray = peopleAndBalances[0].Split(',');
                var currentFloatArray = ConvertStringArrayToFloatArray(splitArray[1..]);


                var currentBiggestLoss = FindHighestBalance(currentFloatArray) - FindLowestBalance(currentFloatArray);

                if (biggestLoss < currentBiggestLoss)
                {
                    biggestLoss = currentBiggestLoss;
                    names = new[] { currentSplitArray[0] };
                }
                else if (biggestLoss == currentBiggestLoss)
                {
                    AddString(names, currentSplitArray[0]);
                }
            }

            return $"{FormatStrings(names)} lost the most money. -¤{biggestLoss}.";
        }

        private static float FindLowestBalance(float[] floatArray)
        {
            float currentLow = floatArray[0];
            for (int i = 1; i < floatArray.Length; i++)
            {
                if (floatArray[i] < currentLow)
                {
                    currentLow = floatArray[i];
                }
            }
            return currentLow;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            var personBalance = peopleAndBalances[0].Split(", ");
            var balanceArray = ConvertStringArrayToFloatArray(personBalance[1..]);

            var biggestBalance = balanceArray[^1];
            var names = new[] { personBalance[0] };

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                personBalance = peopleAndBalances[i].Split(", ");
                balanceArray = ConvertStringArrayToFloatArray(personBalance[1..]);
                var currentBiggestBalance = balanceArray[^1];

                if (currentBiggestBalance > biggestBalance)
                {
                    biggestBalance = currentBiggestBalance;
                    names = new[] { personBalance[0] };
                }
                else if (currentBiggestBalance == biggestBalance)
                {
                    names = AddString(names, personBalance[0]);
                }
            }

            if (names.Length == 1)
            {
                return $"{FormatStrings(names)} is the richest person. ¤{biggestBalance}.";
            }
            return $"{FormatStrings(names)} are the richest people. ¤{biggestBalance}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            var personBalance = peopleAndBalances[0].Split(", ");
            var balanceArray = ConvertStringArrayToFloatArray(personBalance[1..]);

            var lowestBalance = balanceArray[^1];
            var names = new[] { personBalance[0] };

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                personBalance = peopleAndBalances[i].Split(", ");
                balanceArray = ConvertStringArrayToFloatArray(personBalance[1..]);
                var currentLowestBalance = balanceArray[^1];

                if (currentLowestBalance < lowestBalance)
                {
                    lowestBalance = currentLowestBalance;
                    names = new[] { personBalance[0] };
                }
                else if (currentLowestBalance == lowestBalance)
                {
                    names = AddString(names, personBalance[0]);
                }
            }

            string infoLowestBalance = $"¤{lowestBalance}";
            if (lowestBalance < 0)
            {
                infoLowestBalance = $"-¤{-lowestBalance}";
            }

            if (names.Length == 1)
            {
                return $"{FormatStrings(names)} has the least money. {infoLowestBalance}.";
            }
            return $"{FormatStrings(names)} have the least money. {infoLowestBalance}.";
        }
    }
}
