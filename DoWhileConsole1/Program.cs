using System;
using System.Threading;
using System.Globalization;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            Console.WriteLine("Пишіть числа через ентер. Нуль - вихід");
            int summ = 0;
            int number = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                summ += number;
            } while (number != 0);
            Console.WriteLine($"Результат :{summ}");
            Console.ReadKey();
        }
    }
}
