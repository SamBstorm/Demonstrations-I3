using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EnumFlags
{
    [Flags]
    public enum StatusPokemon { Poison = 1, Paralise = 2, Endormi = 4, Gele = 8, Brule = 16, KO = 32}
}
