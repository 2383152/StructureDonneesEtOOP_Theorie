using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2_Dictionnaire
{
    internal class Metal : Substance
    {
        public Metal(int id, string nom, string formule) : base(id, nom, formule, "Gaz") { }

        public override void Reagir()
        {
            {
                Console.WriteLine($"{Nom} ({Formule}) peut réagir avec un acide pour produir un sel et du Dihydrogène");
            }
        }
    }
}
