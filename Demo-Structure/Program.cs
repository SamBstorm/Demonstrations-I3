using System;
using System.Collections.Generic;

namespace Demo_Structure
{
    public struct Donjon {
        public ushort difficulte;
        public List<Etage> etages;
    }

    public struct Etage {
        public int nbEnnemi;
        public string loot;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Donjon donjon1;
            donjon1.difficulte = 1;
            donjon1.etages = new List<Etage>();
            Console.WriteLine(donjon1.difficulte);
            donjon1.etages.Add(new Etage() { nbEnnemi = 3, loot = "Clé donjon" });

            if (donjon1.etages[0].nbEnnemi <= 0) {
                Etage e1 = donjon1.etages[0];
                e1.loot = "Déjà looté!";
                donjon1.etages[0] = e1;
            }

            Donjon donjon2 = new Donjon();
            Console.WriteLine(donjon2.difficulte);
        }
    }
}
