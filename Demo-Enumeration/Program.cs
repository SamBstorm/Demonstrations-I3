using System;
using System.Threading;

namespace Demo_Enumeration
{
    public enum TrafficLigthColors { Green = 1, Orange, Red }

    public struct TrafficLigth
    {
        public TrafficLigthColors currentColor;

        public void ChangeColor()
        {
            switch (currentColor)
            {
                case TrafficLigthColors.Green:
                    currentColor = TrafficLigthColors.Orange;
                    break;
                case TrafficLigthColors.Orange:
                    currentColor = TrafficLigthColors.Red;
                    break;
                case TrafficLigthColors.Red:
                    currentColor = TrafficLigthColors.Green;
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrafficLigth tl;
            #region Menu choix énum format texte
            do
            {
                Console.Clear();
                Console.WriteLine("Veuillez sélectionner une couleur parmis celles-ci :");
                //foreach (string color in Enum.GetNames(typeof(TrafficLigthColors)))
                foreach (string color in Enum.GetNames<TrafficLigthColors>())
                {
                    TrafficLigthColors colorEnum = Enum.Parse<TrafficLigthColors>(color);
                    Console.WriteLine(color);
                }
            } while (!Enum.TryParse<TrafficLigthColors>(Console.ReadLine(), out tl.currentColor));
            #endregion
            #region Menu choix énum format identifiant numérique
            //int tempColor;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Veuillez sélectionner une couleur parmis celles-ci :");
            //    foreach (string color in Enum.GetNames<TrafficLigthColors>())
            //    {
            //        TrafficLigthColors colorEnum = Enum.Parse<TrafficLigthColors>(color);
            //        Console.WriteLine($"{(int)colorEnum} : {colorEnum}");
            //    }
            //} while (!int.TryParse(Console.ReadLine(), out tempColor));
            //tl.currentColor = (TrafficLigthColors)tempColor;
            #endregion



            while (DateTime.Now.Minute != 20)
            {
                tl.ChangeColor();
                switch (tl.currentColor)
                {
                    case TrafficLigthColors.Green:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case TrafficLigthColors.Orange:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        break;
                    case TrafficLigthColors.Red:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                }
                Console.Clear();
                Thread.Sleep(1000);
            }
        }
    }
}
