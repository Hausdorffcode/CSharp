using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hashtableGenericEx
{
    class Program
    {
        public class SamplesHashtable
        {
            public static void Main()
            {
                Hashtable myHT = new Hashtable();    //哈希表
                myHT.Add("Ton V. Bergyk", "023-010-66756");    //add方法，键值对
                myHT.Add("Tom Sony", "086-010-27654");         //与下面一种是hashtable两种不同的添加方法
                myHT.Add("Mr. John", "071-222-33445");

                myHT["Mr. John"] = "071-222-33445"; //加入或修改

                PrintKeysAndValues(myHT);
                PrintByKeys(myHT);

                Console.ReadKey();
            }
            public static void PrintKeysAndValues(Hashtable myList)
            {//遍历hashtable的键值，hashtable实现了IDictionary接口
                IDictionaryEnumerator myEnumerator = myList.GetEnumerator();
                while (myEnumerator.MoveNext())
                    Console.WriteLine("\t{0}:\t{1}",
                        myEnumerator.Key, myEnumerator.Value);
                Console.WriteLine();
            }
            public static void PrintByKeys(Hashtable myList)
            {//遍历hashtable的键
                IEnumerator ie = myList.Keys.GetEnumerator();
                while (ie.MoveNext())
                {
                    object key = ie.Current;
                    object value = myList[key];
                    Console.WriteLine("\t{0}:\t{1}", key, value);
                }
                Console.WriteLine();

                //使用foreach语句，hash table实现了IEnumerable接口
                foreach (string key in myList.Keys)
                {
                    Console.WriteLine("\t{0}:\t{1}", key, myList[key]);
                }
            }
        }

    }
}
