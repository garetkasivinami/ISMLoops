using System;
using System.Threading;
using System.Globalization;
using static System.Math;

namespace PiConsole
{
    class Program
    {
        static decimal minError = decimal.MaxValue;
        static string winName = "";
        static int cyclesCount = 20000;
        static decimal PI = 3.141592653589793238462643M;
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            Console.WriteLine($"Число ПІ {PI}");
            calculateViet();
            calculateJohnWallis();
            calculateLord();
            calculateLeibhts();
            Console.WriteLine($"Найточніший спосіб рахунку числа пі - це спосіб {winName}, оскільки його помилка була мінімальною({minError})");
            Console.ReadKey();
        }
        static void calculateViet ()
        {
            double x = Sqrt(0.5);
            double result = x;
            for (int i = 0; i < cyclesCount; i++)
            {
                x = Sqrt(0.5+0.5*x);
                result *= x;
            }
            result = 2.0 / result;
            checkResult((decimal)result,"Вієта");
        }
        static void calculateJohnWallis ()
        {
            decimal result = 1;
            for (int i = 2; i < cyclesCount; i+=2)
            {
                result *= ((i - 1.0M) * (i + 1.0M)) / (i * i);
            }
            checkResult(2/result, "Джонa Уоллисa");
        }
        static void calculateLord()
        { // щось пішло не так
            decimal divideResult = 1;
            for (int i = 1; i < cyclesCount; i += 2)
            {
                divideResult /= 2 + (i * i);
            }
            checkResult(4M / (divideResult + 1),"лорда Брункера");
        }
        static void calculateLeibhts()
        {
            decimal result = 1;
            for (int i = 1; i < cyclesCount; i++)
            {
                result += 1M / (i * 2 + 1) * (decimal)Pow(-1, i);
            }
            checkResult(result * 4,"Лейбніца");
        }
        static void checkResult (decimal result, string name)
        {
            decimal error = Abs(PI - (result));
            Console.WriteLine($"Помилка {name} становить {error}. Його число ПІ {result}");
            if (minError > error)
            {
                minError = error;
                winName = name;
            }
        }
    }
}
