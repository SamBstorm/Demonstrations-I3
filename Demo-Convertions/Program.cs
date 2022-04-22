using System;

namespace Demo_Convertions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un nombre : ");
            string input = Console.ReadLine();
            int nb1 = Convert.ToInt32(input);

            Console.WriteLine("Veuillez entrer un second nombre : ");
            input = Console.ReadLine();
            int nb2 = int.Parse(input);

            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
        }
    }
}
