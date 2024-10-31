using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Veterinario
{
    internal class ComparerPeso : IComparer<Perro>
    {
        public int Compare(Perro x, Perro y)
        {
            return x.Peso.CompareTo(y.Peso);
        }
    }
}
