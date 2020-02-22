﻿using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileCleaner
    {
        private const string _corruptionChar = "_";
        private const string _emptyChar = "";
        private readonly string _dirtyFile;
        private readonly string _cleanedFile;

        public FileCleaner(string dirtyFile, string cleanedFile)
        {
            if (File.Exists(cleanedFile))
            {
                File.Delete(cleanedFile);
            }
            if (File.Exists(dirtyFile))
            {
                _dirtyFile = dirtyFile;
                _cleanedFile = cleanedFile;
            }
            else
            {
                Console.WriteLine($"{dirtyFile} does not exist!");
            }
        }

        public void Clean()
        {
            string line;

            try
            {
                using StreamReader reader = new StreamReader(_dirtyFile);
                using StreamWriter writer = new StreamWriter(_cleanedFile);
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.Replace(_corruptionChar, _emptyChar));
                }
                // not sure if this is necessary inside a try catch block
                reader.Dispose();
                writer.Dispose();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"The file was not found: {ex}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"The file could not be opened: {ex}");
            }
        }
    }
}