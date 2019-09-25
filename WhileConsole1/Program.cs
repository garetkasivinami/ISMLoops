using System;
using System.Threading;
using System.Globalization;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            Console.WriteLine("Напишіть ціле число!");
            int N = int.Parse(Console.ReadLine());
            int k = 0;
            while(Math.Pow(3,k) <= N)
            {
                k++;
            }
            Console.WriteLine($"Результат :{k}");
            Console.ReadKey();
        }
    }
}
