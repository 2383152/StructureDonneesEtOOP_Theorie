using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2_Dictionnaire
{
    internal class Base : Substance
    {
        public Base(int id, string nom, string formule) : base(id, nom, formule, "Liquide") { }

        public override void Reagir()
        {
            {
                Console.WriteLine($"{Nom} ({Formule}) réagit en libérant des ions )H-");
            }
        }
    }
}
