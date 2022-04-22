using System;

namespace Demo_Comparaison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparaison de chaînes de caractères");
            string text1 = "Toto";
            string text2 = "Titi";
            Console.WriteLine($"{text1} == {text2} : {text1 == text2}");
            Console.WriteLine($"{text1} != {text2} : {text1 != text2}");
            /*Opérateurs de comparaison > , < , <=, >= sont idisponible pour les string*/
            /*Console.WriteLine($"{text1} < {text2} : {text1 < text2}");
            Console.WriteLine($"{text1} <= {text2} : {text1 <= text2}");
            Console.WriteLine($"{text1} > {text2} : {text1 > text2}");
            Console.WriteLine($"{text1} >= {text2} : {text1 >= text2}");*/

            Console.WriteLine("Comparaison de caractères");
            char caractere1 = 'A';
            char caractere2 = 'a';
            Console.WriteLine($"{caractere1} == {caractere2} : {caractere1 == caractere2}");
            Console.WriteLine($"{caractere1} != {caractere2} : {caractere1 != caractere2}");
            Console.WriteLine($"{caractere1} < {caractere2} : {caractere1 < caractere2}");
            Console.WriteLine($"{caractere1} <= {caractere2} : {caractere1 <= caractere2}");
            Console.WriteLine($"{caractere1} > {caractere2} : {caractere1 > caractere2}");
            Console.WriteLine($"{caractere1} >= {caractere2} : {caractere1 >= caractere2}");

            Console.WriteLine("Comparaison d'entiers");
            int entier1 = 42;
            int entier2 = 42;
            Console.WriteLine($"{entier1} == {entier2} : {entier1 == entier2}");
            Console.WriteLine($"{entier1} != {entier2} : {entier1 != entier2}");
            Console.WriteLine($"{entier1} < {entier2} : {entier1 < entier2}");
            Console.WriteLine($"{entier1} <= {entier2} : {entier1 <= entier2}");
            Console.WriteLine($"{entier1} > {entier2} : {entier1 > entier2}");
            Console.WriteLine($"{entier1} >= {entier2} : {entier1 >= entier2}");
        }
    }
}
