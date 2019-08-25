using System;
namespace PolymorphismApplication
{
    public class TestData
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestData data = new TestData();
            int add1 = data.Add(1, 2);
            int add2 = data.Add(1, 2, 3);
            double add3 = data.Add(2.5, 3.6);

            Console.WriteLine("add1 :" + add1);
            Console.WriteLine("add2 :" + add2);
            Console.WriteLine("add3 :" + add3);

            Console.ReadKey();
        }
    }
}
