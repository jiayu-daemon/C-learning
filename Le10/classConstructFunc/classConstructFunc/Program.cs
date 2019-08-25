using System;
namespace LineApplication
{
    class Line
    {
        private double length;   // 线条的长度
        //默认的构造函数没有任何参数。但是如果你需要一个带有参数的构造函数可以有参数，这种构造函数叫做参数化构造函数
        public Line() 
        {
            Console.WriteLine("对象已创建");
        }
        public Line(double len)  // 参数化构造函数
        {
            Console.WriteLine("对象已创建，length = {0}", len);
            length = len;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());


            Line line2 = new Line(10.0);
            Console.WriteLine("线条的长度： {0}", line2.getLength());
            // 设置线条长度
            line2.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line2.getLength());


            Console.ReadKey();
        }
    }
}