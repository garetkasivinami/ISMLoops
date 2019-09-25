using System;
using System.Threading;
using System.Globalization;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            string sA, sB;
            int a, b;
            int result = 1;
            Console.WriteLine("Умова: А<B");
            Console.WriteLine("Напишіть число А");
            sA = Console.ReadLine();
            Console.WriteLine("Напишіть число B");
            sB = Console.ReadLine();
            if (int.TryParse(sA,out a) && int.TryParse(sB,out b))
            {
                for (; a <= b; a++)
                {
                    result *= a;
                }
                Console.WriteLine($"Результат :{result}");
            } else
            {
                Console.WriteLine("Помилка перетворень");
            }
            Console.ReadKey();
        }
    }
}
