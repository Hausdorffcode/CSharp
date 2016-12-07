using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DrawTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleBaseSize = new Size(6, 14);
            this.ClientSize = new Size(600, 500);
            this.Paint += new PaintEventHandler(this.Form1_Paint);  //paint事件
            this.Click += new EventHandler(this.redraw);
        }

        private void redraw(object sender, EventArgs e)
        {
            resetParameter();
            this.Invalidate();
        }

        private void resetParameter()
        {//重置参数
            if(lstth1.SelectedItem != null)
            {
                th1 = double.Parse(lstth1.SelectedItem.ToString()) * Math.PI / 180;
            }
            if (lstth2.SelectedItem != null)
            {
                th2 = double.Parse(lstth2.SelectedItem.ToString()) * Math.PI / 180;

            }
            if (lstper1.SelectedItem != null)
            {
                per1 = double.Parse(lstper1.SelectedItem.ToString());
            }
            if (lstper2.SelectedItem != null)
            {
                per2 = double.Parse(lstper2.SelectedItem.ToString());
            }
            if(txtGoldrate.Text != "")
            {
                goldrate = double.Parse(txtGoldrate.Text);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {//事件处理者
            graphics = e.Graphics;
            width = this.Width - 30;
            height = this.Height - 30;
            drawCayleyTree(10, 300, 400, 100, -PI / 2);
        }

        private Graphics graphics;
        private int width;
        private int height;
        const double PI = Math.PI;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;  //比例系数
        double per2 = 0.7;  //比例系数
        double goldrate = 0.618;

        Random random = new Random();
        private double rand()
        {
            return random.NextDouble();
        }

        private void drawCayleyTree(int n,  //n表示树的级别，也就是递归层数
                double x0, double y0, double leng, double th)  //生长点坐标，长度，角度
        {
            if (n == 0) return;  //递归出口

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng * Math.Cos(th) * goldrate;  //第二生长点
            double y2 = y0 + leng * Math.Sin(th) * goldrate;

            drawLine(x0, y0, x1, y1, n/2);

            drawCayleyTree(n - 1, x1, y1, per1 * leng * (0.5+rand()), th + th1 * (0.5 + rand()));
            drawCayleyTree(n - 1, x2, y2, per2 * leng * (0.4+rand()), th - th2 * (0.4 + rand()));
            if(rand()>0.6)  //40%概率长出第3根分支
                drawCayleyTree(n - 1, x1, y1, per2 * leng * (0.4 + rand()), th - th2 * (0.4 + rand()));
        }

        private void drawLine(double x0, double y0, double x1, double y1, int width )
        {
            graphics.DrawLine(
                new Pen(Color.Blue, width),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
