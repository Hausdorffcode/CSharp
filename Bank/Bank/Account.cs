using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        decimal money;
        string id;
        string pwd;

        public Account(string id, string pwd, decimal money)
        {
            this.id = id;
            this.pwd = pwd;
            this.money = money;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public decimal getMoney()
        {
            return money;
        }

        public void setMoney(decimal money)
        {
            this.money = money;
        }

        public string getpwd()
        {
            return pwd;
        }

        public void setpwd(string pwd)
        {
            this.pwd = pwd;
        }

        public bool isMatch(string id, string pwd)
        {
            return this.id == id && this.pwd == pwd;
        }

        public bool saveMoney(decimal money)
        {
            if (money < 0)
                return false;
            this.money += money;
            return true;
        }

        public bool withdrawMoney(decimal money)
        {
            if(this.money >= money)
            {
                this.money -= money;
                return true;
            }
            return false;
        }
    }
}
