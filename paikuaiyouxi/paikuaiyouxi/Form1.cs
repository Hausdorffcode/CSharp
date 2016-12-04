using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paikuaiyouxi
{
    public partial class Form1 : Form
    {
        const int N = 4; //按钮行数，列数
        Button[,] buttons = new Button[N, N];//按钮数组

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //产生所有按钮
            GenerateAllButtons();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //打乱顺序
            Shuffle();
        }

        //打乱顺序
        private void Shuffle()
        {
            Random random = new Random();
            for(int i = 0; i < 100; i++)
            {
                int a = random.Next(N);
                int b = random.Next(N);
                int c = random.Next(N);
                int d = random.Next(N);
                swap(buttons[a, b], buttons[c, d]);
            }
        }

        //交换两个按钮
        private void swap(Button btn1, Button btn2)
        {
            string t = btn1.Text;
            btn1.Text = btn2.Text;
            btn2.Text = t;         //交换显示文本即可,而本身按钮没动，则tag属性没变

            bool v = btn1.Visible;
            btn1.Visible = btn2.Visible;
            btn2.Visible = v;      //交换visible属性
        }

        //产生所有按钮
        private void GenerateAllButtons()
        {
            int x0 = 100, y0 = 10, w = 45, d = 50;
            for(int r = 0; r < N; r++)
            {
                for(int c = 0; c < N; c++)
                {
                    int num = r * N + c;
                    Button btn = new Button();
                    btn.Text = (num + 1).ToString();
                    btn.Top = y0 + r * d;
                    btn.Left = x0 + c * d;
                    btn.Width = w;
                    btn.Height = w;
                    btn.Visible = true;
                    btn.Tag = num;

                    //注册事件
                    btn.Click += Btn_Click;

                    buttons[r, c] = btn;  //加到数组中
                    this.Controls.Add(btn);//加到界面上
                }
            }
            buttons[N - 1, N - 1].Visible = false; //最后一个按钮不可见
        }

        //按钮点击事件处理
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; //当前点中的按钮
            Button blank = FindBlankButton(); //寻找空白按钮（即不可见的）

            //判断是否与空白按钮相邻，如果是，交换
            if(isNeighbor(btn, blank))
            {
                swap(btn, blank);
            }

            //判断是否完成
            if (isOK())
            {
                MessageBox.Show("Finish!");
            }
        }

        private Button FindBlankButton()
        {
            for(int r = 0; r < N; r++)
            {
                for(int c = 0; c < N; c++)
                {
                    if (!buttons[r, c].Visible)
                        return buttons[r, c];
                }
            }
            return null;
        }

        //判断两个按钮是否相邻
        private bool isNeighbor(Button btn1, Button btn2)
        {
            int btn1R = (int)btn1.Tag / N; //行
            int btn1C = (int)btn1.Tag % N; //列
            int btn2R = (int)btn2.Tag / N;
            int btn2C = (int)btn2.Tag % N;

            if((btn1R == btn2R && Math.Abs(btn1C-btn2C) == 1) || 
               (btn1C == btn2C && Math.Abs(btn1R-btn2R) == 1))
            {
                return true;
            }
            return false;
        }

        private bool isOK()
        {
            for(int r = 0; r < N; r++)
            {
                for(int c = 0; c < N; c++)
                {
                    if (buttons[r, c].Text != (r * N + c + 1).ToString())
                        return false;
                }
            }
            return true;
        }
    }
}
