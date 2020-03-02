﻿using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            const int personCount = 2;

            for (int i = 0; i < personCount; i++)
            {
                ProcessBmi();
            }

            Console.ReadKey();
        }

        public static void ProcessBmi()
        {
            string firstName = PromptString("Input your first name: ");
            string lastName = PromptString("Input your last name: ");
            int age = PromptInt("Input your age: ");
            float height = PromptFloat("Input your height in m: ");
            float weight = PromptFloat("Input your weight in kg: ");
            float bmi = CalculateBmi(weight, height);

            Console.WriteLine($"{firstName} {lastName} is {age} years old, with a weight of {weight} kg and a height of {height} cm.\nCalculated BMI is {bmi}");
            Console.WriteLine();
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);
            int result;

            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Incorrect data entered!");
                PromptInt(message);
            }

            return result;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float result;

            if (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Incorrect data entered!");
                PromptFloat(message);
            }

            return result;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static float CalculateBmi(float weight, float height)
        {
            return (weight / (height * height));
        }
    }
}
