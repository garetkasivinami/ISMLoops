using System;
using System.Threading;
using System.Globalization;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            int number;
            int counter = 1;
            decimal result = 0;
            Console.WriteLine("Напишіть ціле число, яке більше нуля");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (; counter <= number ;counter++)
                {
                    result += (decimal)1/counter;
                }
            }else
            {
                Console.WriteLine("Помилка перетворень!");
            }
            Console.WriteLine($"Результат : {result}");
            Console.ReadKey();

        }
    }
}
