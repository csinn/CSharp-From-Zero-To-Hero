﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public const int InvalidInt = -1;
        public const string InvalidString = "-";
        public const float InvalidFloat = -1;
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool ValidInt;
            if (String.IsNullOrEmpty(input)) return 0;
            ValidInt = int.TryParse(input, out var number);
            if (!ValidInt || number < 0)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return InvalidInt;
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return InvalidString;
            }
            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return 0;
            bool ValidFloat = float.TryParse(input, out var bmiInfo);
            if (!ValidFloat)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return InvalidFloat;
            }
            return bmiInfo;
        }

        public static float CalculateBmi(float weightkg, float heightcm)
        {
            if (weightkg <= 0 && heightcm <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:" + Environment.NewLine);
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightkg}.");
                Console.WriteLine($"Height cannot be less than zero, but was {heightcm}.");
                return InvalidFloat;
            }
            else if (weightkg <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:" + Environment.NewLine);
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightkg}.");
                return InvalidFloat;
            }
            else if (heightcm <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:" + Environment.NewLine);
                Console.WriteLine($"Height cannot be equal or less than zero, but was {heightcm}.");
                return InvalidFloat;
            }
            float bmi = weightkg / heightcm / heightcm;
            return bmi;
        }
    }
}
