using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal abstract class Vehicule
    {
        //quel est la méthode abstract qui rend la méthode abstract. Regarder dans l'énoncé si la méthode se répète dans toutes les classes dérivées (virtual ne serait pas nécéssairement toujours redéfini)
        public double Vitesse { get; set; }
        public int CapaciteTransport { get; set; }

        //Attribut provenant de la relation d'association
        public List<Passenger> Passager { get; set; }

        //Constructeur de la classe
        public Vehicule()
        {
            Passager = new List<Passenger>(); //Initialise la liste des passagers
        }

        //Méthode abstraite que chaque classe de type véhicule doit implémenter
        public abstract void Deplacer(); //Jamais défini

        //Méthode pour afficher les détails du véhicule
        public void AfficherDetail()
        {
            Console.WriteLine($"Vitesse du véhicule: {Vitesse}km/h");
            Console.WriteLine($"Capacité de transport: {CapaciteTransport} personnes");

            foreach(var passenger in Passager)
            {
                Console.WriteLine($"-{passenger.Nom}, {passenger.Age} ans ");
            }
        }

    }
}
