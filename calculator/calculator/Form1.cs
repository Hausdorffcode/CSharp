using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double dblAcc;
        double dblSec;
        bool blnClear, blnFrstOpen;
        string strOper;

        public Form1()
        {
            InitializeComponent();
            dblAcc = 0;   //运算数A，同时也是运算结果
            dblSec = 0;   //运算数B
            blnFrstOpen = true; //判断此时是否是一个数，true为一个数， false为一个数加运算符
            blnClear = true; //判断是否要清空再显示
            strOper = new string('=', 1);
        }

        //加减乘除操作
        private void btn_Oper(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            strOper = tmp.Text;
            if (blnFrstOpen)
                dblAcc = dblSec;
            else
                calc();
            blnFrstOpen = false;
            blnClear = true;
        }

        //数字以及小数点操作
        private void btn_clk(object sender, EventArgs e)
        {
            if (blnClear)
                txtCalc.Text = "";
            Button b3 = (Button)sender;
            txtCalc.Text += b3.Text;
            if (txtCalc.Text == ".")
                txtCalc.Text = "0.";
            dblSec = Convert.ToDouble(txtCalc.Text);
            blnClear = false;
        }

        //清除操作
        private void btn_clr(object sender, EventArgs e)
        {
            clear();
        }

        //等于操作
        private void btn_equ(object sender, EventArgs e)
        {
            calc();
            blnClear = true;
        }

        //所有运算操作
        private void calc()
        {
            switch (strOper)
            {
                case "+":
                    dblAcc += dblSec; //加号运算
                    break;
                case "-":
                    dblAcc -= dblSec; //减号运算
                    break;
                case "*":
                    dblAcc *= dblSec; //乘号运算
                    break;
                case "/":
                    dblAcc /= dblSec; //除号运算
                    break;
            }
            strOper = "="; //等号运算
            blnFrstOpen = true;
            txtCalc.Text = Convert.ToString(dblAcc);//将运算结果转换成字符类型,并输出
            dblSec = dblAcc;//将运算数A的值放入运算数B中,以便后面运算
        }

        //清除按钮的操作
        private void clear()
        {
            dblAcc = 0;
            dblSec = 0;
            blnFrstOpen = true;
            txtCalc.Text = "";
            txtCalc.Focus();//设置焦点为txtCalc
        }
    }
}
