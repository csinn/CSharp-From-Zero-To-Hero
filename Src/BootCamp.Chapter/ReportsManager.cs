﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class ReportsManager
    {
        public static List<Transaction> ReadTransactionFile(string path)
        {
            CheckFilePathForRead(path);
            List<Transaction> transactions = new List<Transaction>();

            string[] transactionsLines = File.ReadAllText(path).Split(Environment.NewLine);

            foreach (string line in transactionsLines)
            {
                if (Transaction.TryParse(line, out Transaction transaction))
                {
                    transactions.Add(transaction);
                }
            }
            if (transactions.Count == 0)
            {
                throw new NoTransactionsFoundException($"{path} contained no vaid transactions.");
            }

            return transactions;
        }

        public static void WriteTimeTransaction(string path, IEnumerable<String> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }

            File.WriteAllLines(path, toBeWritten);
        }
        public static void WriteCityTransaction(string path, IEnumerable<String> toBeWritten)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }

            foreach (String line in toBeWritten)
            {
                File.WriteAllText(path, line);
            }
        }

        private static void CheckFilePathForRead(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new NoTransactionsFoundException($"{nameof(path)} cannot be empty.");
            }
            if (!File.Exists(path))
            {
                throw new NoTransactionsFoundException($"{path} does not exist.");
            }
            if(new FileInfo(path).Length == 0)
            {
                throw new NoTransactionsFoundException($"{path} is empty");
            }
        }
    }
}
