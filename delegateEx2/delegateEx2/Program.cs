using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateEx2
{
    class Program
    {
        delegate void D(int x);  //委托声明

        class C
        {
            public static void M1(int i)
            {
                Console.WriteLine("C.M1: " + i);
            }

            public static void M2(int i)
            {
                Console.WriteLine("C.M2: " + i);
            }

            public void M3(int i)
            {
                Console.WriteLine("C.M3: " + i);
            }
        }

        class Test
        {
            static void Main()
            {
                D cd1 = new D(C.M1);   //委托实例化
                cd1(-1); // call M1    //委托的调用

                D cd2 = null;
                cd2 += new D(C.M2);    //动态增加其中函数
                cd2(-2); // call M2

                D cd3 = cd1 + cd2;      //可以使用+
                cd3(10); // call M1 then M2  //多播

                cd3 += cd1;
                cd3(20); // call M1, M2, then M1     //多个函数间的先后顺序没有意义

                C c = new C();
                D cd4 = new D(c.M3);
                cd3 += cd4;
                cd3(30); // call M1, M2, M1, then M3

                cd3 -= cd1; // remove last M1  //动态减少其中函数

                cd3(40); // call M1, M2, then M3

                cd3 -= cd4;
                cd3(50); // call M1 then M2

                cd3 -= cd2;
                cd3(60); // call M1

                cd3 -= cd2; // impossible removal is benign

                cd3(60); // call M1

                cd3 -= cd1; // invocation list is empty

                Console.WriteLine(cd3 == null);
                // cd3(70); // System.NullReferenceException thrown

                cd3 -= cd1; // impossible removal

                Console.WriteLine(cd3 == null);

                Console.ReadKey();
            }
        }
    }
}
