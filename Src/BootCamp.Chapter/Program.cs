﻿namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson
            string highestBalance = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            TextTable.Build(highestBalance, 3);

            string biggestLoss = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            TextTable.Build(biggestLoss, 3);
            //System.Console.WriteLine(biggestLoss);

            string richestPerson = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            TextTable.Build(richestPerson, 3);
            //System.Console.WriteLine(richestPerson);

            string mostPoorPerson = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);
            TextTable.Build(mostPoorPerson, 3);
            //System.Console.WriteLine(mostPoorPerson);

        }
    }
}
