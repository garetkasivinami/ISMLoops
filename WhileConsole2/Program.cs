using System;
using System.Threading;
using System.Globalization;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            Random random = new Random();
            float percent = random.Next(0,5000) / 10000f;
            float dayDist = 10;
            float dist = dayDist;
            int days = 1;
            Console.WriteLine($"Відсоток: {percent* 100}%");
            while(dist < 200)
            {
                dist += (dayDist *= 1 + percent);
                days++;
            }
            Console.WriteLine($"Спортсмен пробіг {dist} км за {days} днів");
            Console.ReadKey();
        }
    }
}
