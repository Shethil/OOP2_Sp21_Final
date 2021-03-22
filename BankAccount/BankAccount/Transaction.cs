using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount 
{
    class Transaction : Account
    {

        public Account Sender { get; set; }

        public Account Receiver { get; set; }

        public double Amount { get; set; }

        public String AdditionalInfo { get; set; }

        public Transaction()
        {

        }

        public Transaction(Account sender, Account receiver, double amount , string additionalInfo)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Amount = Amount;
            this.AdditionalInfo = additionalInfo;
        }

        public void showInfo()
        {
            Console.WriteLine("Sender name {0}, Account ID:{1}",Sender.AccName,Sender.AccNo);
            Console.WriteLine("Receiver name {0}, Account ID:{1}",Receiver.AccName,Receiver.AccNo);
            Console.WriteLine("Amount Transfer: "+Amount);
            Console.WriteLine("Additional Info : "+AdditionalInfo);
        }

    }
}
