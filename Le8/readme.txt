��������


��ֵ���ݲ���

using System;
namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void swap(int x, int y)
      {
         int temp;
         
         temp = x; /* ���� x ��ֵ */
         x = y;    /* �� y ��ֵ�� x */
         y = temp; /* �� temp ��ֵ�� y */
      }
      
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* �ֲ��������� */
         int a = 100;
         int b = 200;
         
         Console.WriteLine("�ڽ���֮ǰ��a ��ֵ�� {0}", a);
         Console.WriteLine("�ڽ���֮ǰ��b ��ֵ�� {0}", b);
         
         /* ���ú���������ֵ */
         n.swap(a, b);
         
         Console.WriteLine("�ڽ���֮��a ��ֵ�� {0}", a);
         Console.WriteLine("�ڽ���֮��b ��ֵ�� {0}", b);
         
         Console.ReadLine();
      }
   }
}

�����ô��ݲ���

using System;
namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void swap(ref int x, ref int y)
      {
         int temp;

         temp = x; /* ���� x ��ֵ */
         x = y;    /* �� y ��ֵ�� x */
         y = temp; /* �� temp ��ֵ�� y */
       }
   
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* �ֲ��������� */
         int a = 100;
         int b = 200;

         Console.WriteLine("�ڽ���֮ǰ��a ��ֵ�� {0}", a);
         Console.WriteLine("�ڽ���֮ǰ��b ��ֵ�� {0}", b);

         /* ���ú���������ֵ */
         n.swap(ref a, ref b);

         Console.WriteLine("�ڽ���֮��a ��ֵ�� {0}", a);
         Console.WriteLine("�ڽ���֮��b ��ֵ�� {0}", b);
 
         Console.ReadLine();

      }
   }
}


��������ݲ���
return ��������ֻ�Ӻ����з���һ��ֵ�����ǣ�����ʹ�� ������� ���Ӻ����з�������ֵ��
���������ѷ�����������ݸ����Լ����������������ò�������

using System;

namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void getValue(out int x )
      {
         int temp = 5;
         x = temp;
      }
   
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* �ֲ��������� */
         int a = 100;
         
         Console.WriteLine("�ڷ�������֮ǰ��a ��ֵ�� {0}", a);
         
         /* ���ú�������ȡֵ */
         n.getValue(out a);

         Console.WriteLine("�ڷ�������֮��a ��ֵ�� {0}", a);
         Console.ReadLine();
      }

   }
}