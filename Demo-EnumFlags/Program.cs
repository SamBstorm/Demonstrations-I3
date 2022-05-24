using System;

namespace Demo_EnumFlags
{

    class Program
    {
        static void Main(string[] args)
        {
            StatusPokemon poke1 = StatusPokemon.Brule | StatusPokemon.Endormi;

            if (poke1.HasFlag(StatusPokemon.Poison)) Console.WriteLine("Il est empoisonné...");
            if (poke1.HasFlag(StatusPokemon.Paralise)) Console.WriteLine("Il est paralisé...");
            if (poke1.HasFlag(StatusPokemon.Endormi)) Console.WriteLine("Il est endormi...");
            if (poke1.HasFlag(StatusPokemon.Gele)) Console.WriteLine("Il est gelé...");
            if (poke1.HasFlag(StatusPokemon.Brule)) Console.WriteLine("Il est brûlé...");
            if (poke1.HasFlag(StatusPokemon.KO)) Console.WriteLine("Il ne peut plus se battre...");

        }
    }
}
