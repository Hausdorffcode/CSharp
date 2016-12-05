using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExe2
{
    class InterfaceExplicitImpl
    {
        static void Main()
        {
            FileViewer f = new FileViewer();
            f.Test();               //实例调用
            ((IWindow)f).Close();  //强制转化为接口调用

            IWindow w = new FileViewer();  //隐式转化为接口调用
            w.Close();

            Console.ReadKey();
        }
    }

    interface IWindow
    {
        void Close();  //不同接口中的同名方法
    }
    interface IFileHandler
    {
        void Close();  //不同接口中的同名方法
    }
    class FileViewer : IWindow, IFileHandler
    {
        void IWindow.Close()     //显式接口成员实现
        {
            Console.WriteLine("Window Closed");
        }
        void IFileHandler.Close()  //显式接口成员实现
        {
            Console.WriteLine("File Closed");
        }
        public void Test()
        {
            ((IWindow)this).Close();  //调用时只能用接口调用
        }
    }
}
