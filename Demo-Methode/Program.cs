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
            string[] names_prof_array = new string[] { "Samuel", "Loïc", "Aude" };
            string name_prof = ca.ArrayToString(names_prof_array);
            ca.RainbowWriteLine(name_prof);

            string[] test = new string[] { };
            string result_test = ca.ArrayToString(test);
            Console.WriteLine(result_test);
        }
    }
}
