using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем двумерный массив
            int[,] myArr = new int[4, 5];

            Random random = new Random();

            // Инициализируем данный массив
            for (int e = 0; e < 4; e++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[e, j] = random.Next(1, 15);
                    Console.Write("{0}\t", myArr[e, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________");

            int[] array1 = new int[5] { 26, 25, 22, 6, 21 };
            for (int q = 0; q < 5; q++)
            {
                Console.Write("{0}\t", array1[q]);
            }
            Console.WriteLine();
            Console.WriteLine("Длина массива:  {0,3}", array1.Length);
            Console.Write("Введите номер элемента массива: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение: ");
            array1[a] = int.Parse(Console.ReadLine());
            for (int k = 0; k < 5; k++)
            {
                Console.Write("{0}\t", array1[k]);
            }
            Console.WriteLine();
            Console.WriteLine("__________________________________________");

            int f;
            int b;
            int c;
            // Объявляем ступенчатый массив
            int[][] myArr2 = new int[3][];
            myArr2[0] = new int[2];
            myArr2[1] = new int[3];
            myArr2[2] = new int[4];


            // Инициализируем ступенчатый массив
            for (f = 0; f < 2; f++)
            {
                myArr2[0][f] = int.Parse(Console.ReadLine());
            }
            for (b = 0; b < 3; b++)
            {
                myArr2[1][b] = int.Parse(Console.ReadLine());
            }
            for (c = 0; c < 4; c++)
            {
                myArr2[2][c] = int.Parse(Console.ReadLine());
            }

            for (f = 0; f < 2; f++)
            {
                Console.Write("{0}\t", myArr2[0][f]);
            }
            Console.WriteLine();

            for (b = 0; b < 3; b++)
            {
                Console.Write("{0}\t", myArr2[1][b]);
            }
            Console.WriteLine();

            for (c = 0; c < 4; c++)
            {
                Console.Write("{0}\t", myArr2[2][c]);
            }
            Console.WriteLine();

            Console.WriteLine("__________________________________________");
            var s = "Hello";
            Console.WriteLine(s);
            var p = new[] { 0, 1, 2 };
            for (int m = 0; m < 3; m++)
            {
                Console.Write(p[m]+" ");
            }
        }
    }
}