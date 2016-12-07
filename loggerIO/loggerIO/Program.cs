using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace loggerIO
{
    public class Logger
    {
        static void Main()
        {
            LogToFile("msg", true, true);
        }

        public static string LogFile = @"C:\Users\huangqiming\Documents\GitHub\CSharp\loggerIO\aaa.log";

        public static void LogToFile(string str, bool bWithTime, bool bAppendLineFeed)
        {
            if (str == null) return;

            try
            {
                string fname = LogFile;   //文件名

                if (fname == "" || fname == null) return;

                StreamWriter writer = new StreamWriter(fname, true, System.Text.Encoding.Default);  //系统默认编码
                if (bWithTime) writer.WriteLine("\r\n\r\n--------- " + DateTime.Now.ToString());

                if (bAppendLineFeed) writer.WriteLine(str);
                else writer.Write(str);

                writer.Close();  //关闭
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

        }


    }

}
