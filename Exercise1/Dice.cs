using System;

namespace Exercise1
{
    internal class Dice
    {
        public int Sides { get; set; }
        public Dice()
        {
            this.Sides  =  12;
        }

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, Sides+1);
        }
    }
}