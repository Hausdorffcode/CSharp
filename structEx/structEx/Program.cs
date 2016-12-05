using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structEx
{
    class Program
    {
        struct Point      //结构主要用来表示多个分量，是值类型
        { //例如，这里用两个double表示一个点
            public double x, y;      //注意不能给初始值，因为永远执行不到这语句
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public double R()
            {
                return Math.Sqrt(x * x + y * y);
            }
        }

        class Test
        {
            static void Main()
            {
                Point[] points = new Point[100];  //用new声明赋值
                for (int i = 0; i < 100; i++)
                    points[i] = new Point(i, i * i);
            }
        }

    }
}
