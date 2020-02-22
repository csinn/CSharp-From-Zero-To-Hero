﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class StringOps
    {
        public static readonly string InvalidMessage = "N/A.";
        public static readonly string IsTheRichestPerson = "is the richest person";
        public static readonly string AreTheRichestPeople = "are the richest people";
        public static readonly string HadTheMostMoneyEver = "had the most money ever";
        public static readonly string HaveTheLeastMoney = "have the least money";
        public static readonly string HasTheLeastMoney = "has the least money";
        public static readonly string LostTheMostMoney = "lost the most money";

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