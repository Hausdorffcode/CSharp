﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateEx1
{
    class Program
    {//委托实际上是对函数原型的包装，使得可以以变量的方式操作函数
        delegate double Fun(double x);  //声明委托

        public class DelegateIntegral
        {
            public static void Main()
            {
                Fun fun = new Fun(Math.Sin);  //实例化委托
                double d = Integral(fun, 0, Math.PI / 2, 1e-4);  //以变量方式操作函数，这里函数以参数形式出现
                Console.WriteLine(d);
                Fun fun2 = new Fun(Linear);
                double d2 = Integral(fun2, 0, 2, 1e-3);
                Console.WriteLine(d2);
                Rnd rnd = new Rnd();
                double d3 = Integral(new Fun(rnd.Num), 0, 1, 0.01);
                Console.WriteLine(d3);

                Console.ReadKey();
            }

            static double Linear(double a)
            {
                return a * 2 + 1;
            }

            class Rnd
            {
                Random r = new Random();
                public double Num(double x)
                {
                    return r.NextDouble();
                }
            }

            static double Integral(Fun f, double a, double b, double eps)// 积分计算
            {
                int n, k;
                double fa, fb, h, t1, p, s, x, t = 0;
                fa = f(a);
                fb = f(b);
                // 迭代初值
                n = 1;
                h = b - a;
                t1 = h * (fa + fb) / 2.0;
                p = double.MaxValue;
                // 迭代计算
                while (p >= eps)
                {
                    s = 0.0;
                    for (k = 0; k <= n - 1; k++)
                    {
                        x = a + (k + 0.5) * h;
                        s = s + f(x);
                    }
                    t = (t1 + h * s) / 2.0;
                    p = Math.Abs(t1 - t);
                    t1 = t;
                    n = n + n;
                    h = h / 2.0;
                }
                return t;
            }
        }
    }
}