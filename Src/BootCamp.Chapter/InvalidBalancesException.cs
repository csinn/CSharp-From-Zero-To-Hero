﻿using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException(string message, Exception ex) : base (message, ex)
        {
        }
    }
}