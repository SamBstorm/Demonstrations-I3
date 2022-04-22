using System;

namespace Demo_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime day = DateTime.Now;
            int day_id = (int)day.DayOfWeek;
            string message = "Bonjour nous sommes : ";
            switch (day_id)
            {
                case 0:
                    message = message + "Dimanche";
                    break;
                case 1:
                    message = message + "Lundi";
                    break;
                case 2:
                    message = message + "Mardi";
                    break;
                case 3:
                    message = message + "Mercredi";
                    break;
                case 4:
                    message = message + "Jeudi";
                    break;
                case 5:
                    message = message + "Vendredi";
                    break;
                case 6:
                    message = message + "Samedi";
                    break;
                default:
                    message = "Erreur";
                    break;
            }
            Console.WriteLine(message);
            switch (day_id)
            {
                case 0:
                case 6:
                    Console.WriteLine("Et on est les week-end!");
                    break;
                default:
                    Console.WriteLine("Courage! Le weekend approche!");
                    break;
            }
        }
    }
}
