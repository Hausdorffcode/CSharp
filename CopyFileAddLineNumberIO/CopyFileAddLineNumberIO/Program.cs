using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFileAddLineNumberIO
{
    public class CopyFileAddLineNumber  //复制文件并加上行号
    {
        public static void Main(string[] args)
        {
            string infname = @"C:\Users\huangqiming\Documents\GitHub\CSharp\CopyFileAddLineNumberIO\CopyFileAddLineNumberIO\Program.cs";  //读取文件
            string outfname = @"C:\Users\huangqiming\Documents\GitHub\CSharp\CopyFileAddLineNumberIO\CopyFileAddLineNumberIO\CopyFileAddLineNumber.txt";  //写入文件
            if (args.Length >= 1) infname = args[0];
            if (args.Length >= 2) outfname = args[1];

            try
            {
                FileStream fin = new FileStream(
                    infname, FileMode.Open, FileAccess.Read);    //文件流
                FileStream fout = new FileStream(
                    outfname, FileMode.Create, FileAccess.Write);

                StreamReader brin = new StreamReader(
                    fin, System.Text.Encoding.Default);    //FileStream包装成StreamReader
                StreamWriter brout = new StreamWriter(
                    fout, System.Text.Encoding.Default);    //FileStream包装成StreamWriter

                int cnt = 0; // 行号
                string s = brin.ReadLine();     //读取一行，与循环中读入呼应啊
                while (s != null)
                {
                    cnt++;
                    s = deleteComments(s);                        //去掉以//开始的注释
                    brout.WriteLine(cnt + ": \t" + s);           //写出
                    Console.WriteLine(cnt + ": \t" + s);     //在控制上显示
                    s = brin.ReadLine();                      //读入，注意与循环开始时呼应啊
                }
                brin.Close();               // 关闭缓冲读入流及文件读入流的连接.
                brout.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (IOException e2)
            {
                Console.WriteLine(e2);
            }
        }

        static string deleteComments(string s) //去掉以//开始的注释
        {
            if (s == null) return s;
            int pos = s.IndexOf("//"); //找到“//”的索引
            if (pos < 0) return s;
            return s.Substring(0, pos);   //pos这里是长度，正好不包含“//”了
        }
    }

}
