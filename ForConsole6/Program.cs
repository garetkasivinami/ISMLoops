using System;
using System.Threading;
using System.Globalization;

namespace ForConsole6
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
            int count = 0;
            Int64 result = 0;
            if (int.TryParse(Console.ReadLine(), out count))
            {
                for (int i = 1; i <= count; i++)
                {
                    result += (Int64)Math.Pow(i,count - i + 1);
                }
            }
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}
