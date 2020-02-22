﻿using System;

namespace BootCamp.Chapter
{
    public class Account
    {
        private readonly string _name;
        private readonly decimal[] _balance;

        public Account(string balance)
        {
            _name = AccountOps.GetNameForPerson(balance);
            _balance = AccountOps.GetBalanceForPerson(balance);
        }

        public string GetName()
        {
            return _name;
        }

        public decimal[] GetBalance()
        {
            return _balance;
        }

        public decimal GetHighestBalance()
        {
            var highestBalance = ArrayOps.FindArrayMax(_balance);
            return highestBalance;
        }

        public decimal GetLoss()
        {
            try
            {
                decimal previousBallance = _balance[^2];
                decimal currentBalance = _balance[^1];
                decimal loss = currentBalance - previousBallance;

                return loss;
            }
            catch (IndexOutOfRangeException ex)
            {
                // commented it out to keep clean screen
#if DEBUG
                Console.WriteLine(ex.Message);
#endif
            }
            return default;
        }

        public decimal GetCurrentBalance()
        {
            try
            {
                decimal currentBalance = _balance[^1];

                return currentBalance;
            }
            catch (IndexOutOfRangeException ex)
            {
                // commented it out to keep clean screen
#if DEBUG
                Console.WriteLine(ex.Message);
#endif
            }
            return default;
        }

        public decimal GetTotalBalance()
        {
            decimal totalBalance = decimal.Zero;

            for (int i = 0; i < _balance.Length; i++)
            {
                totalBalance += _balance[i];
            }

            return totalBalance;
        }
    }
}