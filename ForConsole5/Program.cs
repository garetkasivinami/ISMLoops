using System;
using System.Threading;
using System.Globalization;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            Console.WriteLine("Напишіть ціле число(>0)");
            int count;
            Int64 result = 0;
            Int64 cache = 1;
            if (int.TryParse(Console.ReadLine(),out count))
            {
                for (int i = 1; i <= count; i++)
                {
                    result += (cache *= i);
                }
            }
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}
