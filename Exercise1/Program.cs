using System;
using System.Globalization;
using System.Numerics;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("enter date: ");
            //string date1 = console.readline();
            //datetime datetime1;
            //try
            //{
            //    datetime1 =  datetime.parseexact(date1, "d-m-yyyy", cultureinfo.invariantculture);
            //    console.writeline(datetime1.dayofweek);
            //}
            //catch (exception e)
            //{
            //    console.writeline(e.message);
            //}
            cd:Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Gray;
            
            Console.WriteLine("Insert your number");
            BigInteger f = int.Parse(Console.ReadLine());
            BigInteger fac = 1;
            for (int i = 1; i <= f; i++)
            {
                fac*= i;
            }
            Console.WriteLine(fac);
            Console.ResetColor();
            goto cd;
        }
        
    }
}
