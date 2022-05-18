using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methode
{
    public struct ConsoleAvance { 
        
        public void RainbowWriteLine()
        {
            string message = "Hello rainbowWorld!";
            for (int i = 0; i < message.Length; i++)
            {
                int dif = 15 - 9;
                Console.ForegroundColor = (ConsoleColor)((i % dif) + 9);
                Console.Write(message[i]);
            }
        }

        public void ArrayWriteLine()
        {
            string[] array = { "Virginie", "Shaila", "Resa", "Alina", "Charlotte", "Naïké", "Julie", "Vanessa", "Manon", "Zineb", "Scheherazad", "Cristine", "Hajar" };
            Console.Write("[");
            foreach (string arrayElement in array)
            {
                Console.Write($"{arrayElement},");
            }
            Console.Write("\b]");
            Console.WriteLine();
        }

    }

}
