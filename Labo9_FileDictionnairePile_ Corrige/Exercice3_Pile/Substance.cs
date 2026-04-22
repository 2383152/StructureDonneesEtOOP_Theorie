using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3_Pile
{
    internal class Substance
    {
        public string Nom { get; set; }
        public string Formule { get; set; }
        public string EtatPhysique { get; set; }
        public double MasseMolaire { get; set; }

        public Substance(string nom, string formule, string etatPhysique, double masseMolaire)
        {
            Nom = nom;
            Formule = formule;
            EtatPhysique = etatPhysique;
            MasseMolaire = masseMolaire;           
        }

        public override string ToString()
        {
            return $"{Nom} ({Formule}) - {EtatPhysique}, {MasseMolaire} g/mol";
        }
    }
}
