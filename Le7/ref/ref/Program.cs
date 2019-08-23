using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        public void swapval(int x, int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }


        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            /* 局部变量定义 */
            int a = 100;
            int b = 200;

            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);

            n.swapval(a,b);
            Console.WriteLine("1在交换之后，a 的值： {0}", a);
            Console.WriteLine("1在交换之后，b 的值： {0}", b);

            /* 调用函数来交换值 */
            n.swap(ref a, ref b);

            Console.WriteLine("2在交换之后，a 的值： {0}", a);
            Console.WriteLine("2在交换之后，b 的值： {0}", b);

            Console.ReadLine();

        }
    }
}
