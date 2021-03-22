using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using TreinamentoDia5_Section11_146.Entities.Exceptions;

namespace TreinamentoDia5_Section11_146.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return "New Balance: " +
                Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
