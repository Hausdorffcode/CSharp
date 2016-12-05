using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public delegate void BigMoneyEventHandler(object sender, BigMoneyArgs e); //声明委托

    public class BankDemo
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.OpenAccount("aaa", "111", 100);
            bank.OpenAccount("bbb", "222", 500);
            bank.OpenAccount("ccc", "333", 1000);
            bank.OpenCreditAccount("dddd", "4444", 1, 1000);
            bank.OpenCreditAccount("eeee", "5555", 200);
            ATM atm = new ATM(bank);
            atm.BigMoneyFetched += Atm_BigMoneyFetched; //注册事件

            for(int i = 0; i < 5; i++)
            {
                atm.Transaction();
            }
        }

        private static void Atm_BigMoneyFetched(object sender, BigMoneyArgs e)
        {//事件处理者
            Console.WriteLine("Waring! Your account: " + e.Myaccount.Id + " had been withdrew " + e.TheWithdrawMoney);
        }
    }
}
