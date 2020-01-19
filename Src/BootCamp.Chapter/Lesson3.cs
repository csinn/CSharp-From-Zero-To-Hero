﻿using System;


namespace BootCamp.Chapter
{    public class Lesson3
    {   public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                GatherData(out string firstName, out string lastName, out int age, out float weight, out float height);
                DisplayOutput(firstName, lastName, age, weight, height);
            }
        }
        public static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public static int GetIntInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static float GetFloatInput(string prompt)
        {
            Console.WriteLine(prompt);
            return float.Parse(Console.ReadLine());
        }
        // Input function
        public static void GatherData(out string firstName, out string lastName, out int age, out float weight, out float height)
        {
            firstName = GetStringInput("Hello, What is your First name? ");
            lastName = GetStringInput("Hello, What is your Last name? ");

            age = GetIntInput("How old are you?");
            weight = GetFloatInput("How much do you weigh in kilograms?");
            height = GetFloatInput("How tall are you?") / 100;
            Console.Clear();
        }
        // Output function
        public static void DisplayOutput(string first, string last, int age, float weight, float height)
        {
            Console.WriteLine(first + " " + last + " is " + age + " years old; his weight is " + weight + " kg and his height is " + (height * 100) + " cm.");
            Console.WriteLine(first + "'s Body Mass Index is " + CalcBmi(weight, height) + ".");
            Console.WriteLine("\n\n\n\n\nPress Enter");
            Console.ReadLine();
        }
        //Calculate BMI
        public static float CalcBmi(float weight, float height)
        {

            return weight / (height * height);

        }
    }
}