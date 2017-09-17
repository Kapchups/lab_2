using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static Tuple<int, string, char, string, ulong> CreateCorteg(int age, string secondname, char a, string firstname, ulong date)
        {
            int t = age;
            string s = secondname;
            char x = a;
            string s2 = firstname;
            ulong l = date;
            Console.WriteLine("__________________________________________________________");
            var t1 = Tuple.Create(123, "Hello");
            var t2 = Tuple.Create(123, "Hello");
            Console.WriteLine(t1 == t2); // Кортежи являются классами и следовательно ссылочными типами. По этой причине сравнение двух экземпляров кортежей с помощью оператора == вернет false.
            Console.WriteLine(t1.Equals(t2)); // Метод Equals, напротив, перегружен  и выполняет сравнение каждого элемента кортежа.
            Console.WriteLine("__________________________________________________________");

            return Tuple.Create<int, string, char, string, ulong>(t,s,x,s2,l);
        }
        static void Main(string[] args)
    {

        var c = CreateCorteg(18, "Marchuk", 'A', "Valera", 19990126);
            Console.WriteLine("Кортеж целиком: ");
            Console.WriteLine("Возраст:{0}\nФамилия:{1}\nСимвол:{2}\nИмя:{3}\nДата:{4}\n", c.Item1, c.Item2, c.Item3, c.Item4, c.Item5);
            Console.WriteLine("Элементы кортежа(1,3,4):");
            Console.WriteLine("Фамилия:{0}\nИмя:{1}\nДата:{2}\n", c.Item2, c.Item4, c.Item5);
           
            Console.WriteLine("__________________________________________________________");

        }
    }
}
