using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        protected decimal money; //将字段设为protected
        protected string id;
        protected string pwd;

        public Account(string id, string pwd, decimal money)
        {
            this.id = id;
            this.pwd = pwd;
            this.money = money;
        }

        public string Id  //使用属性
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public decimal Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public string Pwd
        {
            get { return this.pwd; }
            set { this.pwd = value; }
        }

        public bool isMatch(string id, string pwd)
        {
            return this.id == id && this.pwd == pwd;
        }

        public bool saveMoney(decimal money)
        {
            Random random = new Random();
            if (money < 0)
                return false;
            if(random.Next(100) < 100)
            {
                throw new BadCashException("Bad Cash"); //抛出异常
            }
            this.money += money;
            return true;
        }

        public virtual bool withdrawMoney(decimal money)
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
