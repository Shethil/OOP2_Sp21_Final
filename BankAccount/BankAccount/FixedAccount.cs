﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class FixedAccount : Account
    {
        public int TenureYear { get; set; }
        public int OpeningYear { get; set; }

        public FixedAccount()
        {

        }

        public FixedAccount(string accName, string accNo, double balance, int tenureYear , int openingYear): base(accName, accNo, balance)
        {

        }

        public override void Withdraw(double amount)
        {
            //base.Withdraw(amount);
            int crYear = DateTime.Now.Year;
            if (crYear - OpeningYear >TenureYear)  
            {
                Console.WriteLine("Insufficient Year");
            }
            else
            {
                Console.WriteLine("Your account has been debited by {0} to self", amount);
            }
        }
    }
}
