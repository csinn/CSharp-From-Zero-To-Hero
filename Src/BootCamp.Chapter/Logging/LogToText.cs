﻿using System;
using System.IO;

namespace BootCamp.Chapter.Logging
{
    class LogToText : Log
    {

        public string GetConnection()
        {
            return @"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logging\Log.txt";
        }
        public override void LogNow(string text)
        {
            File.AppendAllText(GetConnection(), $"{DateTime.Now}: {text}" + "\r\n");
        }
        public override string Type()
        {
            return "Text";
        }
    }

}
