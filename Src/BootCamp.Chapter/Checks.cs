﻿using System;
using System.Collections.Generic;
using System.Text;

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
        public static int PromptInt(string message)
        {
            return Lesson4.PromptInt;
        }

        public static string PromptString(string message)
        {
            return Lesson4.PromptString;
        }

        public static float PromptFloat(string message)
        {
            return Lesson4.PromptFloat;
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmiResult = Lesson4.CalculateBmi(weight, height);
            return bmiResult;
        }
    }
}
