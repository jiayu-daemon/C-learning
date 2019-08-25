/*
 我们可以使用 static 关键字把类成员定义为静态的。
 当我们声明一个类成员为静态时，意味着无论有多少个类的对象被创建，只会有一个该静态成员的副本。

关键字 static 意味着类中只有一个该成员的实例。
静态变量用于定义常量，因为它们的值可以通过直接调用类而不需要创建类的实例来获取。

静态变量可在成员函数或类的定义外部进行初始化。你也可以在类的定义内部初始化静态变量
 */
using System;
namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num ;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}