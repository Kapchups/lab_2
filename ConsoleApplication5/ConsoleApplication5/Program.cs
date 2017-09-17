using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static int Sum(int[] array1)
        {
            int sum=0;   
            for(int i=0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            return sum;
        }
        static int Max(int[] array1)
        {
            int Max = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > Max)
                    Max = array1[i];
            }
            return Max;
        }
        static int Min(int[] array1)
        {
            int Min=array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < Min)
                    Min = array1[i];
            }
            return Min;
        }
        static string str(string s)
        {
            string s1 = s.Substring(0,1);//начало и длина
            return s1;
        }
            static void Main(string[] args)
        {
            string s = "Строка";
            int[] array1 = new int[] { 6, 26, 21, 22, 25 };
            Console.WriteLine(Sum(array1));
            Console.WriteLine(Max(array1));
            Console.WriteLine(Min(array1));
            Console.WriteLine(str(s));
        }
    }
}
