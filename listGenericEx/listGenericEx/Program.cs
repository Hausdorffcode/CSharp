using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listGenericEx
{
    class Program
    {
        public class ListTest
        {
            public static void Main()
            {
                List<string> fruits = new List<string>();    //list泛型
                fruits.Add("Apple");                 //add方法
                fruits.Add("Banana");
                fruits.Add("Carrot");

                Console.WriteLine("Count: {0}", fruits.Count);  //count方法
                PrintValues1(fruits);
                PrintValues2(fruits);
                PrintValues3(fruits);

                Console.ReadKey();
            }

            static void PrintValues1(IList<string> myList)
            {//用一般for语句遍历，通过索引器访问
                for (int i = 0; i < myList.Count; i++)
                    Console.Write("{0}\n", myList[i]);
            }
            static void PrintValues2(IList<string> myList)
            {//通过foreach语句遍历，只读
                foreach (string item in myList)
                    Console.Write("{0}\n", item);
            }
            static void PrintValues3(IEnumerable<string> myList)
            {//foreach语句内部实现
                IEnumerator<string> myEnumerator = myList.GetEnumerator();
                while (myEnumerator.MoveNext())
                    Console.Write("{0}\n", myEnumerator.Current);
                Console.WriteLine();
            }
        }

    }
}
