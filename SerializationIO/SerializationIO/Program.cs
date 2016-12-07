using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializationIO
{
    [Serializable]  //可序列化
    class Book
    {
        public string name;
        //public double price;
        public int num = 13; //如果book的版本变了，反序列化时，这个默认值不会被执行
        public string[] reader;
        public double price;

        override public string ToString()
        {
            return name + ":" //+ price 
                + ":" + string.Join(",", reader)
                + ":" + num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestBinary();
        }

        static void TestBinary()
        {
            BinaryFormatter formatter = new BinaryFormatter();   //格式化对象

            //Serialization of String Object
            Book book = new Book();
            book.name = "学习C#";
            book.price = 123.45;
            book.reader = new string[] { "张三", "李四", "王五" };

            FileStream stream = new FileStream(@"C:\Users\huangqiming\Documents\GitHub\CSharp\SerializationIO\SerializationIO\StrObj.t", FileMode.Create, FileAccess.Write,
              FileShare.None);
            formatter.Serialize(stream, book);  //序列化
            stream.Close();


            //Deserialization of String Object
            FileStream readstream = new FileStream(@"C:\Users\huangqiming\Documents\GitHub\CSharp\SerializationIO\SerializationIO\StrObj.t", FileMode.Open, FileAccess.Read,
              FileShare.Read);
            Book book2 = (Book)formatter.Deserialize(readstream);  //反序列化成流，再强制类型转化
            readstream.Close();
            Console.WriteLine(book2);
            Console.ReadLine();

        }
    }
}
