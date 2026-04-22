using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3_Pile
{
    internal class Reactif : Substance
    {
        public string Dangerosite {  get; set; }
        public Reactif(string nom, string formule, string etatPhysique, double masseMolaire, string dangerosite) : base(nom, formule, etatPhysique, masseMolaire) 
        {
            Dangerosite = dangerosite;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Dangerosite;
        }
    }
}
