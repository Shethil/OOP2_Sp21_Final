using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
             Account a1 = new CurrentAccount("Shethil", "001", 50000);
             Account a2 = new SavingsAccount("Shethil", "002", 50000);
             Account a3 = new FixedAccount("Shethil", "003", 50000, 9, 2017);

           /* a1.ShowInfo();
              a2.ShowInfo();
              a3.ShowInfo(); 

              a1.Withdraw(50000);
              a2.Withdraw(50000);
              a3.Withdraw(50000); 

             a1.Transfer(a2, 10000);

             a1.ShowInfo();
             a2.ShowInfo(); 

             Customer c = new Customer();
             c.AddAccount(a1, a2, a3);
             var acc = c.GetAccount("001");
             acc.Withdraw(49600);
             c.ShowAccDetails(); */


            a1.Withdraw(5000);
            a1.Deposit(1000);
            a1.ShowAllTransaction();
            a1.ShowInfo();

            a2.Transfer(a1, 10000);
            a2.ShowAllTransaction();
            a2.ShowInfo();
            
        }
    }
}
