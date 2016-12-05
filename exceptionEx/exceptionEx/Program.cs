using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionEx
{
    class Program
    {
        public class DataHouse
        {
            public static void FindData(long ID)
            {
                if (ID > 0 && ID < 1000)
                    Console.WriteLine(ID);
                else
                    throw new DataHouseException("已到文件尾");//抛出异常，异常是一个类的实例
            }
        }
        public class BankATM
        {
            public static void GetBalanceInfo(long ID)
            {
                try
                {
                    DataHouse.FindData(ID);
                }
                catch (DataHouseException e)
                {
                    throw new MyAppException("账号不存在", e); //异常链接，其中e为内部异常，使外部进一步知道内部的异常原因
                }
            }
        }
        public class DataHouseException : ApplicationException  //自定义的异常，从Exception或ApplicationException继承
        {
            public DataHouseException(string message)
                : base(message)
            { }
        }
        public class MyAppException : ApplicationException
        {
            public MyAppException(string message)
                : base(message)
            { }
            public MyAppException(string message, Exception inner) //异常链接
                : base(message, inner) //继承父类的信息
            { }
        }
        public class Test
        {
            public static void Main()
            {
                try
                {
                    BankATM.GetBalanceInfo(12345L);
                }
                catch (Exception e)
                {
                    Console.WriteLine("出现了异常： {0}", e.Message);
                    Console.WriteLine("内部原因： {0}", e.InnerException.Message);//InnerException访问内部异常
                }

                Console.ReadKey();
            }
        }

    }
}
