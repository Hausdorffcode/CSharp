using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    //声明定义事件参数类
    public class BigMoneyArgs 
    {
        private Account myaccount;
        private decimal theWithdrawMoney;

        public Account Myaccount
        {
            get { return this.myaccount;}
            set { this.myaccount = value; }
        }

        public decimal TheWithdrawMoney
        {
            get { return this.theWithdrawMoney; }
            set { this.theWithdrawMoney = value; }
        }

        public BigMoneyArgs(Account account, decimal money)
        {
            this.theWithdrawMoney = money;
            this.myaccount = account;
        }
        
    }
}
