using System;

namespace Demo_Methode
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleAvance ca;
            ca.RainbowWriteLine("Somewhere over the rainbow!");
            string[] names = { "Virginie", "Shaila", "Resa", "Alina", "Charlotte", "Naïké", "Julie", "Vanessa", "Manon", "Zineb", "Scheherazad", "Cristine", "Hajar" };
            ca.ArrayRainbowWriteLine(names);
            ca.ArrayWriteLine(new int[10]);
        }
    }
}
