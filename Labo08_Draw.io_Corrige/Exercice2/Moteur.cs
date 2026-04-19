using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Moteur
    {
        public string TypeMoteur { get; set; }
        public double Puissance { get; set; }

        public void Demarrer()
        {
            Console.WriteLine("Le moteur démarre");
        }

        public void Arret()
        {
            Console.WriteLine("le moteur s'arrête");
        }
    }
}
