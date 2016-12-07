using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace listAllFiles
{
    class ListAllFiles
    {
        public static void Main(string[] args)
        {
            ListFiles(new DirectoryInfo(@"C:\Users\huangqiming\Documents\python\互评"));  //@后面的字符串不转义

            Console.ReadKey();
        }

        public static void ListFiles(FileSystemInfo info)   //FileSystemInfo是DirectoryInfo和FileInfo的父类
        {
            if (!info.Exists) return;

            DirectoryInfo dir = info as DirectoryInfo;
            if (dir == null) return; //不是目录

            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i] as FileInfo;
                if (file != null) // 是文件
                {
                    Console.WriteLine(
                        file.FullName + "\t" + file.Length);
                }
                else    //是目录
                {
                    ListFiles(files[i]);  //对于子目录,进行递归调用
                }
            }
        }
    }

}
