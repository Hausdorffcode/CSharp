using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverrideEx2
{
    class Program
    {
        public struct Digit
        {
            byte value;
            public Digit(byte value)
            {
                if (value < 0 || value > 9) throw new ArgumentException();
                this.value = value;
            }
            public Digit(int value) : this((byte)value) { }

            //注意：运算符重载都是public， static的
            public static implicit operator byte(Digit d)  //类型转化运算符重载，隐式
            {//从Digit到byte的隐式转换操作符。
                return d.value;      //注意参数类型及返回类型
            }
            public static explicit operator Digit(byte b)   //类型转化运算符重载，显式
            {//从byte到Digit的隐式转换操作符
                return new Digit(b);    //注意参数类型及返回类型
            }
            public static Digit operator +(Digit a, Digit b)
            {//把两个Digit数值相加并返回一个Digit数值的加法操作符
                return new Digit(a.value + b.value);
            }
            public static Digit operator -(Digit a, Digit b)
            {//把一共Digit数值与其它Digit数值相减，并返回一共digit数值的减法操作符
                return new Digit(a.value - b.value);
            }
            public static bool operator ==(Digit a, Digit b)
            {//比较两个digit数值的等式
                return a.value == b.value;
            }
            public static bool operator !=(Digit a, Digit b)
            {//比较两个digit数值的非等式
                return a.value != b.value;
            }
            public override bool Equals(object value)
            {
                return this == (Digit)value;
            }
            public override int GetHashCode()
            {
                return value.GetHashCode();
            }
            public override string ToString()
            {
                return value.ToString();
            }
        }
        class Test
        {
            static void Main()
            {
                Digit a = (Digit)5;
                Digit b = (Digit)3;
                Digit plus = a + b;
                Digit minus = a - b;
                bool equals = (a == b);
                Console.WriteLine("{0} + {1} = {2}", a, b, plus);
                Console.WriteLine("{0} - {1} = {2}", a, b, minus);
                Console.WriteLine("{0} == {1} = {2}", a, b, equals);
            }
        }
        /*
        Digit类型定义了下面的操作符：
        ·   从Digit到byte的隐式转换操作符。
        ·   从byte到Digit的隐式转换操作符
        ·   把两个Digit数值相加并返回一个Digit数值的加法操作符。
        ·   把一共Digit数值与其它Digit数值相减，并返回一共digit数值的减法操作符。
        ·   比较两个digit数值的等式和非等式。
        */

    }
}
