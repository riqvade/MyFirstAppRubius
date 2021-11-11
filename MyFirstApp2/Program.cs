using System;

namespace MyFirstApp2
{
    namespace AppLogic
    {
        /*
         * Это многострочный комментарий
 * Используется для дмногословных описаний
 */
        internal class Program
        {
            /// <summary>
            /// Точка входа приложения
            /// </summary>
            /// <param name="args">аргументы коммандной строки</param>
            static void Main(string[] args/*аргументы командной строки*/)
            {
                Console.WriteLine("Hello World!");

                //string userName = Console.ReadLine();

                //Console.WriteLine("Hello " + userName);
                //Console.WriteLine("Nice to meet you");

                string имя = "Вася"; // так делать можно, но не нужно
                // Ключевые слова использовать в качестве названия переменной нельзя
                string @string = "f"; // но крайне не рекомендуется

                //string UserName = Console.ReadLine();

                // Single line comment
                // Целочисленные значения
                int a = 5;
                int b = 3;
                int c = a + b;
                Console.WriteLine(c);

                // вещественные числа
                double d = 3.2;
                double e = 2.0;
                double de = d + e;
                //float f = 2.3f;
                //decimal dd = 2.3M;
                Console.WriteLine("Результат сложения вещественных чисел: " + de);

                string s1 = "строка 1";
                string s2 = "строка 2";
                string s3 = s1 + s2;
                Console.WriteLine("Результат конкатенации строк: " + s3);

                bool boolValue = s1 == s2;
                Console.WriteLine("Результат сравнения двух строк: " + boolValue);


                //Console.WriteLine(a);
                //long b = 5;
                //Console.WriteLine(b);
                //string s = "строка";
                //Console.WriteLine(s);

                //object o = 7;
                //Console.WriteLine("Переменная типа object " + o);
                //Console.WriteLine(o.GetType());
                //o = "строка";
                //Console.WriteLine(o);
                //Console.WriteLine(o.GetType());


                Console.WriteLine("Good Bye");
            }
        }
    }

}
