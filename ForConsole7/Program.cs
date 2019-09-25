using System;
using System.Threading;
using System.Globalization;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            Console.WriteLine("Напишіть ціле число(>0)(N)");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишіть ціле число(>0)(K)");
            int K = int.Parse(Console.ReadLine());
            Int64 result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += (Int64)Math.Pow(N,K);
            }
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}
