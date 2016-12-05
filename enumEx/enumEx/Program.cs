using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumEx
{
    class Program
    {
        enum LightColor   //枚举主要用来表示符号化的常量，值类型
        {
            Red,
            Yellow,
            Green
        }
        class TrafficLight
        {
            public static void WhatInfo(LightColor color)
            {
                switch (color)            //常与switch语句配合使用
                {
                    case LightColor.Red:
                        Console.WriteLine("Stop!");
                        break;
                    case LightColor.Yellow:
                        Console.WriteLine("Warning!");
                        break;
                    case LightColor.Green:
                        Console.WriteLine("Go!");
                        break;
                    default:
                        break;
                }
            }
        }

        class Test
        {
            static void Main()
            {
                LightColor c = LightColor.Red;   //像普通类型一样声明，赋值
                Console.WriteLine(c.ToString());
                TrafficLight.WhatInfo(c);
            }
        }
    }
}
