using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class VehiculeAerien : Vehicule
    {
        public double Altitude { get; set; }
        //Attributs ou propriétés provenant des relations
        public Moteur Moteur1 { get; set; } //relation de composition

        public List<Aeroport> Aeroports { get; set; } //relation d'association directionnelle

        //Constructeur (besoin du constructeur pour initialiser la list
        public VehiculeAerien()
        {
            Aeroports =new List<Aeroport>(); //Initialise la liste des Aeroport
        }

        public override void Deplacer()
        {
            Console.WriteLine("Le véhicule aerien vole");
        }

        public void Voler()
        {
            Console.WriteLine("le véhicule dans le ciel!");
        }

        //Méthode pour simuler l'attérissage à un aeroport
        public void Atterir(Aeroport aeroport)
        {
            Console.WriteLine($"le véhicu;er aerien atterit a l'aéroport {aeroport.Nom}");
        }
    }
}
