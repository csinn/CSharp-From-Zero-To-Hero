﻿namespace BootCamp.Chapter
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
            // To do: call your implementation. 
            return Program.InputInteger(message);
        }

        public static string PromptString(string message)
        {
            // To do: call your implementation. 
            
            return Program.InputString(message);
        }

        public static float PromptFloat(string message)
        {
            // To do: call your implementation. 
            return Program.InputFloat(message);
        }

        public static float CalculateBmi(float weight, float height)
        {
            // To do: call your implementation. 
            return Program.CalculateBmi(weight,height);
        }
    }
}