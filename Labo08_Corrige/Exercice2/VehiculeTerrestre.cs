using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class VehiculeTerrestre : Vehicule
    {
        public string TypeCarburant { get; set; }

        //Attributs ou propriétés provenant de la relation de composition forte avec la classe Moteur
        public Moteur Moteur1 { get; set; }

        //Implémentation de la méthode abstraite déplacé
        public override void Deplacer()
        {
            Console.WriteLine("Le véhicule terrestre roule");
        }

        public void Rouler()
        {
            Console.WriteLine("Le véhicule roule sur la route");
        }
    }
}
