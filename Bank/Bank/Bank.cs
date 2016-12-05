using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bank
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public Account OpenAccount(string id, string pwd, decimal money)
        {
            Account account = new Account(id, pwd, money);
            accounts.Add(account);
            return account;
        }

        public CreditAccount OpenCreditAccount(string id, string pwd, decimal money, int credit)
        {
            CreditAccount creditAccount = new CreditAccount(id, pwd, money, credit);
            accounts.Add(creditAccount);
            return creditAccount;
        }

        public CreditAccount OpenCreditAccount(string id, string pwd, decimal money) //重载
        {
            CreditAccount creditAccount = new CreditAccount(id, pwd, money);
            accounts.Add(creditAccount);
            return creditAccount;
        }

        public bool CloseAccount(Account account)
        {
            int idx = accounts.IndexOf(account);
            if (idx < 0) return false;         //防止账号不存在
            accounts.Remove(account);
            return true;
        }

        public Account FindAccount(string id, string pwd)
        {
            foreach(Account account in accounts)
            {
                if (account.isMatch(id, pwd))
                    return account;
            }
            return null;
        }
    }
}
