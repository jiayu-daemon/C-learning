��װ

using System;

namespace RectangleApplication
{
    class Rectangle
    {
        //��Ա����
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("���ȣ� {0}", length);
            Console.WriteLine("��ȣ� {0}", width);
            Console.WriteLine("����� {0}", GetArea());
        }
    }// Rectangle ����

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}


using System;

namespace RectangleApplication
{
    class Rectangle
    {
        //��Ա����
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("�����볤�ȣ�");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("�������ȣ�");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("���ȣ� {0}", length);
            Console.WriteLine("��ȣ� {0}", width);
            Console.WriteLine("����� {0}", GetArea());
        }
    }//end class Rectangle    
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}


��չ ����װ �� ��̬�� / ��̬�⡣

ΪʲôҪ����װ



