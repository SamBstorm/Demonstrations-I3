using System;
using System.Threading;

namespace Demo_Boucle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Demo avec nombres
            /*string bobette = "O----------";
            int pos_O;
            Console.WriteLine(bobette);
            Thread.Sleep(200);
            for (pos_O = 1; pos_O < bobette.Length + 1; pos_O++)
            {
                Console.Clear();
                int nbTirret = 0;
                do
                {
                    Console.Write("-");
                    nbTirret++;
                }
                while (nbTirret < pos_O);
                Console.Write("O");
                while (nbTirret < bobette.Length)
                {
                    Console.Write("-");
                    nbTirret++;
                }
                Thread.Sleep(200); */
            #endregion
            #region Boucle avec taille inconnue

            //Console.WriteLine("Veuillez entrer un numéro BBAN (12 chiffres) :");
            //string bban = Console.ReadLine();
            ////while (bban.Length != 12 || !ulong.TryParse(bban, out _))
            //while ( !(bban.Length == 12 && ulong.TryParse(bban, out _)))
            //   {
            //    Console.WriteLine("Les \"Coffee shrimps\" ont demandé d'avoir 12 chiffres :");
            //    bban = Console.ReadLine();
            //}


            //string bban;
            //do
            //{
            //    Console.WriteLine("Veuillez entrer un numéro BBAN (12 chiffres) :");
            //    bban = Console.ReadLine();
            //} while (bban.Length != 12 || !ulong.TryParse(bban, out _));

            //string bban;
            //string message = "Veuillez entrer un numéro BBAN (12 chiffres) :";
            //do
            //{
            //    Console.WriteLine(message);
            //    bban = Console.ReadLine();
            //    message = "Les \"Coffee shrimps\" ont demandé d'avoir 12 chiffres :";
            //} while (bban.Length != 12 || !ulong.TryParse(bban, out _));

            Console.WriteLine("Veuillez entrer un numéro BBAN(12 chiffres) :");
            for (string bban = Console.ReadLine(); bban.Length !=12 || !ulong.TryParse(bban, out _); bban = Console.ReadLine())
            {
                Console.WriteLine("Les \"Coffee shrimps\" ont demandé d'avoir 12 chiffres :");
            }
            #endregion

        }
    }
}
