using System;
namespace InheritanceApplication
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // 派生类
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            // 调用基类的方法
            Rect.setWidth(5);
            Rect.setHeight(7);

            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}