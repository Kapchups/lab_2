using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()//Exercise1
        {
            int num = -10;
            uint num_1 = 11;
            float f = 1.23f;
            bool boolearn = false;
            string name = "Kapchups";
            char n = 'K';
            byte e = 255;
            sbyte b = -128;
            short s = -32768;
            ushort u = 65535;
            long l = 24242424;
            ulong ul = 18446744073709551615;
            double d = -1.79769313486232;
            decimal m = 110;
            object i = num;
            System.Console.WriteLine("Определение и инициализация всех переменных примитивных типов:");
            System.Console.WriteLine("_________________________");
            System.Console.WriteLine(num);
            System.Console.WriteLine(num_1);
            System.Console.WriteLine(f);
            System.Console.WriteLine(boolearn);
            System.Console.WriteLine(name);
            System.Console.WriteLine(n);
            System.Console.WriteLine(e);
            System.Console.WriteLine(b);
            System.Console.WriteLine(s);
            System.Console.WriteLine(u);
            System.Console.WriteLine(l);
            System.Console.WriteLine(ul);
            System.Console.WriteLine(d);
            System.Console.WriteLine(m);
            System.Console.WriteLine(i);
            System.Console.WriteLine("_________________________");
            Int32 i32 = 5;
            Int64 i64 = i32;//неявное приведение Int32 к Int64
            Single o = i32;//неявное приведение Int32 к Single
            Double z = i32;//неявное приведение Int32 к char
            Decimal c = i32;//неявное приведение Int32 к Decimal
            Object ui = i32;//неявное приведение Int32 к Object
            Byte y = (Byte)i32;//явное приведение Int32 к Byte
            Int16 v = (Int16)s;//явное приведение Single к Int16
            System.Console.Write("Явное приведение Single к Int16: ");
            System.Console.WriteLine(v);
            System.Console.Write("Неявное приведение Int32 к Decimal: ");
            System.Console.WriteLine(c);
            System.Console.WriteLine("_________________________");
            int g = 10;
            object p = g;//упаковка g
            byte m1 = (byte)(int)p;//распаковка, а затем приведение типа
            System.Console.WriteLine(m1);
            System.Console.WriteLine("_________________________");
            var myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            foreach (var i1 in myList)
            {
                Console.WriteLine(i1);
            }
            System.Console.WriteLine("_________________________");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Проверка на равенство объектов:");
            int? x1 = null;
            int? x2 = null;
            System.Console.WriteLine(x1 == x2);//True
        }
    }   
}
