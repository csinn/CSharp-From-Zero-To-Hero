﻿using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter.Csv
{
    public class CsvReader : CsvBase
    {
        public CsvReader(string filePath) : base(filePath)
        {
        }

        public CsvReader(string filePath, CsvDelimiter delimiter, bool hasHeader) : base(filePath, delimiter, hasHeader)
        {
        }

        public IEnumerable<CsvRow> ReadAllRows()
        {
            var line = string.Empty;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(FilePath);
                if (reader.EndOfStream)
                {
                    throw new NoTransactionsFoundException();
                }

                if (HasHeader)
                {
                    if (TryParseRow(reader?.ReadLine(), out CsvRow header))
                    {
                        Header = header;
                    }
                }

                while ((line = reader.ReadLine()).IsValid())
                {
                    if (TryParseRow(line, out CsvRow csvRow))
                    {
                        Rows.Add(csvRow);
                    }
                }
            }
            finally
            {
                reader?.Close();
            }

            return Rows;
        }
    }
}