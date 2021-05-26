using System;

namespace Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
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
            //cd:Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.Gray;

            //Console.WriteLine("Insert your number");
            //BigInteger f = int.Parse(Console.ReadLine());
            //BigInteger fac = 1;
            //for (int i = 1; i <= f; i++)
            //{
            //    fac*= i;
            //}
            //Console.WriteLine(fac);
            //Console.ResetColor();
            //goto cd;
            //Dice dice = new Dice();
            //Console.ForegroundColor = ConsoleColor.Red;
            ////Console.WriteLine(dice.Roll());

            Console.WriteLine("Number of songs");
            int numberOfSongs = int.Parse(Console.ReadLine());
            int sn = numberOfSongs-1;
            string[] allSongs = new string[numberOfSongs];
            Console.WriteLine("Enter following: [List Type]_[Name of song]_[time]");
            while (true)
            {
                string song = Console.ReadLine();
                string[] songs = song.Split("_");
                Song s = new Song(songs);
                numberOfSongs--;
                int i = sn - numberOfSongs;
                allSongs[i] = s.Name;
                if (numberOfSongs == 0) break;
            }

            Console.WriteLine("Name of all songs");
            foreach (string a in allSongs)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}