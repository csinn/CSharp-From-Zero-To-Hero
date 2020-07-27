﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class TextTable
    {
        private readonly string _message;

        public string GetMessage()
        {
            return _message;
        }

        private int _padding;

        public int GetPadding()
        {
            return _padding;
        }

        public void SetPadding(int newPadding)
        {
            _padding = newPadding;
        }

        public TextTable(string message, int padding)
        {
            if (String.IsNullOrEmpty(message)) _message = "";
            _message = message;

            if (padding < 0) throw new ArgumentException("Padding on Text Table can't be less than 0");
            _padding = padding;
        }

        public TextTable(string message)
        {
            if (String.IsNullOrEmpty(message)) _message = "";
            _message = message;
            _padding = 0;

        }

        public string Build()
        {
            if (String.IsNullOrEmpty(_message)) return "";

            var sb = new StringBuilder();

            string[] messageLines = _message.Split(Environment.NewLine);

            sb.Append(AddBorder(messageLines, _padding));
            sb.Append(AddPaddingLines(messageLines, _padding));
            sb.Append(AddMessageLines(messageLines, _padding));
            sb.Append(AddPaddingLines(messageLines, _padding));
            sb.Append(AddBorder(messageLines, _padding));

            return sb.ToString();
        }

        private static string AddBorder(string[] messageLines, int padding)
        {
            int lineLength = LineLength(messageLines, padding);
            string border = CreateLine('+', '-', lineLength);
            return border;
        }

        private static string AddPaddingLines(string[] messageLines, int padding)
        {
            int lineLength = LineLength(messageLines, padding);
            if (padding == 0) return "";

            var line = new StringBuilder();
            for (int i = 0; i < padding; i++)
            {
                line.Append(CreateLine('|', ' ', lineLength));

            }
            return line.ToString();
        }

        private static string AddMessageLines(string[] messageLines, int padding)
        {
            int maxContentLength = LengthOfTheLongestLine(messageLines);

            var allMessageLines = new StringBuilder();
            for (int i = 0; i <= messageLines.Length - 1; i++)
            {
                string margin = "".PadRight(padding);
                string content = messageLines[i].PadRight(maxContentLength);
                allMessageLines.Append($"|{margin}{content}{margin}|{Environment.NewLine}");
            }
            return allMessageLines.ToString();
        }

        private static int LengthOfTheLongestLine(string[] messageLines)
        {
            int longestLine = 0;
            foreach (string line in messageLines)
            {
                if (line.Length > longestLine) longestLine = line.Length;
            }

            return longestLine;
        }

        private static string CreateLine(char border, char inside, int lineLength)
        {
            return $"{border}{"".PadRight(lineLength, inside)}{border}{Environment.NewLine}";
        }

        private static int LineLength(string[] messageLines, int padding)
        {
            int maxContentLength = LengthOfTheLongestLine(messageLines);
            return maxContentLength + padding * 2;
        }
    }
}
