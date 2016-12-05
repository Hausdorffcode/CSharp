using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace attributeEx
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Class
     | AttributeTargets.Method,
     AllowMultiple = true)]                            //HelpAttribute类的一个attribute
        public class HelpAttribute : System.Attribute   //定义attribute，从Attribute中继承
        {
            public readonly string Url;
            private string topic;
            public string Topic      // 属性 Topic 是命名参数
            {
                get
                {
                    return topic;
                }
                set
                {
                    topic = value;
                }
            }
            public HelpAttribute(string url)  // url 是位置参数
            {//构造函数
                this.Url = url;
            }
        }

        [HelpAttribute("http://msvc/MyClassInfo", Topic = "Test"),
        Help("http://my.com/about/class")]            //MyClass的一个attribute， 使用时可省略Attribute
        class MyClass
        {
            [Help("http;//my.com/about/method")]
            public void MyMethod(int i)
            {
                return;
            }
        }

        public class MemberInfo_GetCustomAttributes
        {
            public static void Main()
            {
                Type myType = typeof(MyClass);

                object[] attributes = myType.GetCustomAttributes(false);  //反射
                for (int i = 0; i < attributes.Length; i++)
                {
                    PrintAttributeInfo(attributes[i]);
                }

                MemberInfo[] myMembers = myType.GetMembers();
                for (int i = 0; i < myMembers.Length; i++)
                {
                    Console.WriteLine("\nNumber {0}: ", myMembers[i]);
                    Object[] myAttributes = myMembers[i].GetCustomAttributes(false);
                    for (int j = 0; j < myAttributes.Length; j++)
                    {
                        PrintAttributeInfo(myAttributes[j]);
                    }
                }
            }

            static void PrintAttributeInfo(object attr)
            {
                if (attr is HelpAttribute)
                {
                    HelpAttribute attrh = (HelpAttribute)attr;
                    Console.WriteLine("----Url: " + attrh.Url + "  Topic: " + attrh.Topic);
                }
            }
        }
    }
}
