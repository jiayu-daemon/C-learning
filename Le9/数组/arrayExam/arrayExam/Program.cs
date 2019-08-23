using System;
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */
            int i, j;
            int k = 3;
            /* 初始化数组 n 中的元素 */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            /* 输出每个数组元素的值 */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1} {2}", j, n[j],k);
            }

            /* 使用foreach语句输出，代码更明了*/
            int index = 0;
            foreach (int num in n)
            {
                Console.WriteLine("=Element[{0}] = {1}", index, num);
                index++;
            }

            // 理解foreach语句
            index = 0;
            foreach (int num in n)
            {
                Console.WriteLine("#Element[{0}] = {1}", index, n[index]);
                index++;
            }
            Console.ReadKey();
        }
    }
}
