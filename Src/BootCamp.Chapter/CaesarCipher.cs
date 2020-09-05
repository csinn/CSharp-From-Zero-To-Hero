﻿using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
        public static string Encrypt(string message, byte shift)
        {
            return string.IsNullOrEmpty(message) ? message : EncryptedMessage(message, shift, true); 
        }

        private static string EncryptedMessage(string message, byte shift, bool shiftRight)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(message);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                int newAsciiNumber;

                if (shiftRight)
                {
                    newAsciiNumber = (asciiBytes[i] + shift) % 255;
                }
                else
                {
                    newAsciiNumber = (asciiBytes[i] - shift);

                    if (newAsciiNumber < 0)
                    {
                        newAsciiNumber = 255 + newAsciiNumber;
                    }
                }

                asciiBytes[i] = (byte)newAsciiNumber;
            }

            char[] asciiChars = Encoding.ASCII.GetChars(asciiBytes);
            return new string(asciiChars);
        }

        public static string Decrypt(string message, byte shift)
        {
            return string.IsNullOrEmpty(message) ? message : EncryptedMessage(message, shift, false);
        }
    }
}
