using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bank
{
    class ATM
    {
        Bank bank;

        public ATM(Bank bank)
        {
            this.bank = bank;
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Transaction()
        {
            Show("please input your card");
            string id = GetInput();
            Show("please input your password");
            string pwd = GetInput();

            Account account = bank.FindAccount(id, pwd);
            if(account == null)
            {
                Show("sorry, i can't find your account");
                return;
            }
            Show("1.display, 2.save, 3.withdraw");
            string op = GetInput();
            switch (op)
            {
                case "1":
                    Show("balance: " + account.getMoney());
                    break;
                case "2":
                    Show("please enter your money you want to save");
                    decimal money2 = decimal.Parse(GetInput());
                    if (account.saveMoney(money2))
                    {
                        Show("ok");
                    }
                    else
                    {
                        Show("error");
                    }
                    Show("balance: " + account.getMoney());
                    break;
                case "3":
                    Show("please enter the money you want to withdraw");
                    decimal money3 = decimal.Parse(GetInput());
                    if (account.withdrawMoney(money3))
                    {
                        Show("ok");
                    }
                    else
                    {
                        Show("you don't have enough money");
                    }
                    Show("balance: " + account.getMoney());
                    break;
                default:
                    Show("your enter is invalid");
                    break;
            }

        }
    }
}
