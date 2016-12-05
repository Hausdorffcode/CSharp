using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExe
{
    interface Runner
    {
        void run();
    }

    interface Swimmer
    {
        void swim();
    }

    //抽象类
    abstract class Animal  
    {
        abstract public void eat();  //抽象方法
    }

    class Person : Animal, Runner, Swimmer
    {
        public void run()
        {
            Console.WriteLine("run");
        }
        public void swim()
        {
            Console.WriteLine("swim");
        }
        public override void eat()
        {
            Console.WriteLine("eat");  //重写方法
        }
        public void speak()
        {
            Console.WriteLine("speak");
        }
    }

    class TestInterface
    {
        //静态方法
        static void m1(Runner r)
        {
            r.run();
        }
        static void m2(Swimmer s)
        {
            s.swim();
        }
        static void m3(Animal a)
        {
            a.eat();
        }
        static void m4(Person p)
        {
            p.speak();
        }

        public static void Main(string[] args)
        {
            Person p = new Person();
            m1(p);
            m2(p);
            m3(p);    //隐式转化为animal
            m4(p);
            Runner a = new Person();  //接口类型
            a.run();                  //通过接口调用
            Console.ReadKey();
        }
    }

}
