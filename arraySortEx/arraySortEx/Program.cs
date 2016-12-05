using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySortEx
{
    class Program
    {
        public class Test
        {
            public static void Main(string[] args)
            {
                string[] ary =
                {
                "Apple", "pineapple", "banana", "cherry",
                };
                Show(ary);
                Array.Sort(ary);//按照默认方式排序
                Show(ary);
                Array.Sort(ary, (a, b) => a.Length - b.Length);//sort方法中传入待排序的array以及比较方法，该方法采用lammbda表达式
                Show(ary);


                int i = Array.BinarySearch(ary, "Pearl"); //二分查找
                Console.WriteLine(i);
                Array.Reverse(ary); //逆转
                Show(ary);

                Console.ReadKey();
            }

            //遍历显示array中元素
            public static void Show(object[] ary)
            {//Array类实现了IEnumerable接口
                foreach (object obj in ary)
                    Console.Write(obj + " ");
                Console.WriteLine();
            }
        }
    }
}
