using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CreditAccount : Account //继承
    {
        private int credit;  //新增加信用字段
        private const int creditRate = 100;

        public CreditAccount(string id, string pwd, decimal money, int credit) : base(id, pwd, money)
        {//构造方法新增字段，构造函数重载
            this.credit = credit;
        }

        public CreditAccount(string id, string pwd, decimal money) : base(id, pwd, money)
        {
            //原来版本的构造函数,新增默认信用
            this.credit = 60;
        }

        public int Credit   //信用属性
        {
            get { return credit; }
            set { credit = value; }
        }

        public override bool withdrawMoney(decimal money)
        {
            if (this.money + this.credit * creditRate >= money)
            {
                this.money -= money;
                return true;
            }
            return false;
        }

    }
}
