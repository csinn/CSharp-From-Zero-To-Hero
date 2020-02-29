﻿using System;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private readonly string _currency = Settings.currencySymbol;
        private readonly Account[] _accounts;

        // this is used in conjuncture with FormatAndCommas
        private const int _arrayBreak = 2;

        public BalanceStats(Account[] accounts)
        {
            _accounts = accounts;
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public string FindHighestBalanceEver()
        {
            if (_accounts is null)
            {
                return Messages.InvalidMessage;
            }

            Account highestBalanceAccount = _accounts[0];

            for (int i = 1; i < _accounts.Length; i++)
            {
                if (_accounts[i].GetHighestBalance() > highestBalanceAccount.GetHighestBalance())
                {
                    highestBalanceAccount = _accounts[i];
                }
            }

            return _accounts.Length > _arrayBreak && AccountOps.CheckBalancesEquality(_accounts)
              ? $"{StringOps.FormatAndCommas(_accounts)} {Messages.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), _currency)}."
              : $"{highestBalanceAccount.GetName()} {Messages.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), _currency)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public string FindPersonWithBiggestLoss()
        {
            if (_accounts is null)
            {
                return Messages.InvalidMessage;
            }

            Account biggestLossAccount = _accounts[0];

            // can not calculate Loss if account has only one balance entry
            if (biggestLossAccount.GetBalance().Length == 1)
            {
                return Messages.InvalidMessage;
            }

            for (int i = 0; i < _accounts.Length; i++)
            {
                if (_accounts[i].GetLoss() < biggestLossAccount.GetLoss())
                {
                    biggestLossAccount = _accounts[i];
                }
            }

            return _accounts.Length > _arrayBreak && AccountOps.CheckBalancesEquality(_accounts)
                ? $"{Messages.InvalidMessage}"
                : $"{biggestLossAccount.GetName()} {Messages.LostTheMostMoney}. {StringOps.FormatCurrency(biggestLossAccount.GetLoss(), _currency)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public string FindRichestPerson()
        {
            if (_accounts is null)
            {
                return Messages.InvalidMessage;
            }

            Account richestBalanceAccount = _accounts[0];

            for (int i = 1; i < _accounts.Length; i++)
            {
                if (_accounts[i].GetCurrentBalance() > richestBalanceAccount.GetCurrentBalance())
                {
                    richestBalanceAccount = _accounts[i];
                }
            }

            return _accounts.Length > _arrayBreak && AccountOps.CheckBalancesEquality(_accounts)
              ? $"{StringOps.FormatAndCommas(_accounts)} {Messages.AreTheRichestPeople}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), _currency)}."
              : $"{richestBalanceAccount.GetName()} {Messages.IsTheRichestPerson}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), _currency)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public string FindMostPoorPerson()
        {
            if (_accounts is null)
            {
                return Messages.InvalidMessage;
            }

            Account poorestBalanceAccount = _accounts[0];

            for (int i = 1; i < _accounts.Length; i++)
            {
                if (_accounts[i].GetCurrentBalance() < poorestBalanceAccount.GetCurrentBalance())
                {
                    poorestBalanceAccount = _accounts[i];
                }
            }

            return _accounts.Length > _arrayBreak && AccountOps.CheckBalancesEquality(_accounts)
                ? $"{StringOps.FormatAndCommas(_accounts)} {Messages.HaveTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), _currency)}."
                : $"{poorestBalanceAccount.GetName()} {Messages.HasTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), _currency)}.";
        }
    }
}