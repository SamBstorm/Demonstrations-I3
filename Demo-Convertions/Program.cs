using System;

namespace Demo_Convertions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un nombre : ");
            string input = Console.ReadLine();
            //int nb1 = Convert.ToInt32(input);
            int nb1;
            bool isConvert = int.TryParse(input, out nb1 ); 


            Console.WriteLine("Veuillez entrer un second nombre : ");
            input = Console.ReadLine();
            //int nb2 = int.Parse(input);
            isConvert = int.TryParse(input, out int nb2);

            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
        }
    }
}
