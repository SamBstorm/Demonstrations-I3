using System;
using System.Collections.Generic;

namespace Demo_Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tableau 1 dimenssions
            //const int TAILLE = 13;
            //string[] student_names = new string[TAILLE];
            //for (int i = 0; i < student_names.Length; i++)
            //{
            //    student_names[i] = Console.ReadLine();
            //    Console.Clear();
            //}

            //foreach (string name in student_names)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region Tableaux N dimenssions
            //string[] student_names = { "Alina",
            //    "Resa",
            //    "Shaila",
            //    "Virginie",
            //    "Charlotte", 
            //    "Naïké", 
            //    "Scheherazad", 
            //    "Vanessa", 
            //    "Julie", 
            //    "Cristine",
            //    "Manon",
            //    "Hajar",
            //    "Zineb" };
            //string[] course_names = { "Modélisation", "Texturing", "Programmation" };
            //double[,] cotations = new double[student_names.Length, course_names.Length];

            //for (int i = 0; i < student_names.Length; i++)
            //{
            //    Console.WriteLine($"Voici la fiche de {student_names[i]} :");
            //    for (int j = 0; j < course_names.Length; j++)
            //    {
            //        do
            //        {
            //            Console.Write($"Veuillez introduire la côte pour le cours de {course_names[j]} :");
            //        } while (!double.TryParse(Console.ReadLine(), out cotations[i, j]));
            //    }
            //}
            #endregion

            #region Collection générique

            //List<string> student_names = new List<string>();
            //string input;
            //do
            //{
            //    Console.WriteLine("Veuillez introduire un nom :");
            //    input = Console.ReadLine();
            //    student_names.Add(input.Trim());
            //} while (input.ToUpper().Trim() != "FIN");
            //student_names.Remove(student_names[student_names.Count-1]);

            #endregion

            #region Dictionnaire

            Dictionary<string, double> cotations = new Dictionary<string, double>();

            string student;
            do
            {
                Console.WriteLine("Veuillez indiquer le nom de l'étudiant :");
                student = Console.ReadLine().Trim();
                if (student.ToUpper() != "FIN")
                {
                    if (cotations.ContainsKey(student)) Console.WriteLine($"L'étudiant {student} a {cotations[student]}");
                    else
                    {
                        double cote;
                        do Console.WriteLine($"Veuillez indiquer la côte de {student}:");
                        while (!double.TryParse(Console.ReadLine(), out cote));
                        cotations.Add(student, cote);
                    }
                }
            } while (student.ToUpper() != "FIN");

            #endregion
        }
    }
}
