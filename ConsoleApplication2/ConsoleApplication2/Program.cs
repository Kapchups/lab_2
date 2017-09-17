using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
            {
            string path;
            path = "C:\\Windows\\regedit.exe";//строковый литерал
            System.Console.WriteLine(path);
            string s = "abc grgr";
            string s1 = "bcaaaaaa eheh";
            string s2 = "Kap ge";
            System.Console.WriteLine(s);
            System.Console.WriteLine(s1);
            System.Console.WriteLine("__________________________");
            Console.WriteLine(String.Compare(s, s1));//Сравнивает значения двух строк. Возвращает целочисленное значение.
            System.Console.WriteLine("__________________________");

            System.Console.WriteLine(string.Concat(s1, s));
        
            System.Console.WriteLine(string.Copy(s1));

            //Выделение подстрок
            string name1 = "Это тестовая строка";
            System.Console.WriteLine(name1.Substring(6,8));//начало и длина

            //разделение строки на слова
            const string Text = "This is a test string";
            string[] words = Text.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            //вставка подстроки в заданную позицию
            string text = "Хороший день";
            string subString = "замечательный ";
            text = text.Insert(8, subString);
            Console.WriteLine(text);

            //удаление заданной подстроки
            string text1 = "Хороший день";
            // индекс последнего символа
            int ind = text1.Length - 4;
            // вырезаем последний символ
            text1 = text1.Remove(ind);
            Console.WriteLine(text1);
            // вырезаем первые два символа
            text1 = text1.Remove(0, 2);

            System.Console.WriteLine("__________________________");

            //Строка — null если ей не было назначено значение (в C++ и Visual Basic)
            //или явно назначено значение null. Несмотря на то что составное форматирование
            //компонент может аккуратно пустой строки, как показано в следующем примере,
            //попытка вызова одного Если вызывает его члены NullReferenceException.
            String str3 = null;
            Console.WriteLine("The value of the string is '{0}'", str3);
            try
            {
                Console.WriteLine("String length is {0}", str3.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            //Строка пуста, если явно присваивается пустая строка ("») или String.Empty.
            //Пустая строка имеет Length 0. В следующем примере создается пустая строка
            //и отображает его значение и его длина.
            String str4 = "";
            Console.WriteLine("The length of '{0}' is {1}.", str4, str4.Length);

            System.Console.WriteLine("__________________________");

            //создание StringBuilder
            StringBuilder MyStringBuilder = new StringBuilder("Hello World!");
            //Добавляет сведения в конец текущего StringBuilder
            MyStringBuilder.Append(" What a beautiful day.");
            Console.WriteLine(MyStringBuilder);
            //Добавляет сведения в начало текущего StringBuilder
            MyStringBuilder.Insert(0, "Wow, ");
            Console.WriteLine(MyStringBuilder);
            //Удаляет определённые позиции StringBuilder
            MyStringBuilder.Remove(5, 6);
            Console.WriteLine(MyStringBuilder);
        }
    }
}
