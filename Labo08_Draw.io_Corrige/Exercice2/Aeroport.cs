using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Aeroport
    {
        public string Nom {  get; set; }
        public string Localisation { get; set; }

        //on se sert du constructeur par défault

        public void Atterir()
        {
            Console.WriteLine("Le vehicule aérien attérit");
        }

        public void Decoller()
        {
            Console.WriteLine("Le vehicule aérien décolle");
        }


    }
}
