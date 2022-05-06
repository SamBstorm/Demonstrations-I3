using System;

namespace Demo_Operateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ternaire - (...) ? ... : ...
            string skin_Perso;
            bool user_gender_is_female = true;
            if (user_gender_is_female)
            {
                skin_Perso = "Alex";
            }
            else
            {
                skin_Perso = "Steve";
            }

            skin_Perso = (user_gender_is_female) ? "Alex" : "Steve";
            #endregion
            #region Coalesce - ... ?? ...
            string equipement_joueur = null; //Début de jeu, pas d'équipement donc null

            string equipement_loot = null; // Loot aléatoire d'un coffre

            if (equipement_loot == null)
            {
                equipement_joueur = "Aucun équipement";
            }
            else {
                equipement_joueur = equipement_loot;
            }

            equipement_joueur = equipement_loot ?? "Aucun équipement";  //Si la valeur de gauche du ?? est null, alors on récupère la valeur de droite, sinon, celle de gauche

            #endregion
            #region est compatible - ... is ...
            object o = Console.ReadLine();

            if (o.GetType() == typeof(string)) Console.WriteLine("C'est une string!");
            else Console.WriteLine("Ce n'est pas une string...");

            if(o is string) Console.WriteLine("C'est une string!");
            else Console.WriteLine("Ce n'est pas une string...");

            //switch (o)
            //{
            //    case string s:
            //        Console.WriteLine("C'est une string!");
            //    default:
            //        else Console.WriteLine("Ce n'est pas une string...");
            //        break;
            //}

            #endregion
            #region convertir si compatible - ... as ...
            object o2 = Console.ReadLine();

            string s = o2 as string;
            if (o2 is string) {
                s = (string)o;
            }
            else {
                s = null;
            }
            #endregion
        }
    }
}
