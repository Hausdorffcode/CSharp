using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace reciteWord
{
    [Serializable]
    public class ParameterClass
    {
        public string wordFile = @"C:\Users\huangqiming\Documents\GitHub\CSharp\reciteWord\College_Grade4.txt";  //单词文件
        public string[] englishArray;  //英语数组
        public string[] chineseArray;  //汉语数组
        public int arrayindex = 0;         //记录下标索引
    }
}
