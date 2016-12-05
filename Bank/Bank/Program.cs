using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankDemo
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.OpenAccount("aaa", "111", 100);
            bank.OpenAccount("bbb", "222", 500);
            bank.OpenAccount("ccc", "333", 1000);
            ATM atm = new ATM(bank);

            for(int i = 0; i < 5; i++)
            {
                atm.Transaction();
            }
        }
    }
}
