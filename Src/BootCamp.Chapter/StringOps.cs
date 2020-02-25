﻿using System.Text;

namespace BootCamp.Chapter
{
    public static class StringOps
    {
        /// <summary>
        /// Return formated output for multiple accounts (Kai, EarLington and Mihail).
        /// </summary>
        public static string FormatAndCommas(Account[] validPeople)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < validPeople.Length; i++)
            {
                sb.Append(validPeople[i].GetName());
                if (i + 2 < validPeople.Length)
                {
                    sb.Append(", ");
                }
                else if (i + 1 < validPeople.Length)
                {
                    sb.Append(" and ");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns an formated output of currency (ex. -¤1, ¤4, ¤1002, -¤1001).
        /// </summary>
        public static string FormatCurrency(decimal value, string currencySymbol)
        {
            const char negativeSymbol = '-';

            var formatedCurrency = new StringBuilder();

            if (value < 0)
            {
                value *= -1;
                formatedCurrency.Append(negativeSymbol).Append(currencySymbol).Append(value);
                return formatedCurrency.ToString();
            }

            formatedCurrency.Append(currencySymbol).Append(value);
            return formatedCurrency.ToString();
        }
    }
}