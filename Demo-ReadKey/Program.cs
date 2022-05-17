using System;

namespace Demo_ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("Veuillez entrer une combinaison de touches :");
                keyInfo = Console.ReadKey(true);
                Console.WriteLine(keyInfo.Key);
                Console.WriteLine(keyInfo.Modifiers);
            //} while (keyInfo.Modifiers != ConsoleModifiers.Shift || keyInfo.Key != ConsoleKey.Q);
            } while (!(keyInfo.Modifiers == ConsoleModifiers.Shift && keyInfo.Key == ConsoleKey.Q));
        }
    }
}
