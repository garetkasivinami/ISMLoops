using System;
using System.Threading;
using System.Globalization;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            Console.WriteLine("Напишіть число");
            decimal number;
            if (!decimal.TryParse(Console.ReadLine(),out number))
            {
                throw new Exception("Помилка перетворення!");
            }
            decimal result = number;
            int step;
            Console.WriteLine("Напишіть степінь(>0)");
            if (int.TryParse(Console.ReadLine(),out step))
            {
                for (int i = 1; i < step; i++)
                {
                    result *= number;
                }
                Console.WriteLine($"Результат : {result}");
            } else
            {
                Console.WriteLine("Помилка перетворення");
            }
            Console.ReadKey();
        }
    }
}
