using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioTryCatch.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public Account()
        { 
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Witydraw(double amount)
        {
            if (amount >= WithdrawLimit) 
            {
            throw new DomainException("")
            }
            Balance -= amount;
        }
    }
}
