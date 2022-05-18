using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methode
{
    public struct ConsoleAvance { 
        
        public void RainbowWriteLine(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                int dif = 15 - 9;
                Console.ForegroundColor = (ConsoleColor)((i % dif) + 9);
                Console.Write(message[i]);
            }
        }

        public void ArrayWriteLine(string[] array)
        {
            
            Console.Write("[");
            foreach (string arrayElement in array)
            {
                Console.Write($"\"{arrayElement}\",");
            }
            Console.Write("\b]");
            Console.WriteLine();
        }
        public void ArrayWriteLine(int[] array)
        {

            Console.Write("[");
            foreach (int arrayElement in array)
            {
                Console.Write($"{arrayElement},");
            }
            Console.Write("\b]");
            Console.WriteLine();
        }

        public void ArrayRainbowWriteLine(string[] array)
        {
            RainbowWriteLine("[");
            foreach (string arrayElement in array)
            {
                RainbowWriteLine($"\"{arrayElement}\",");
            }
            RainbowWriteLine("\b]");
            Console.WriteLine();
        }
    }

}
