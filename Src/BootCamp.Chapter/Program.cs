﻿using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmi1(number:1);

            Bmi1(number:2);
        }
        private static void Bmi1(int number)
        {
            Console.WriteLine("Person #" + number+ ":" );

            Console.Write("Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            float weight = float.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            float height = float.Parse(Console.ReadLine());

            float bmi = weight / (height * height) * 10000;

            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg, his height is " + height + " and his bmi is " + bmi + ".");

            Console.WriteLine(" ");

        }
        
    }
}
