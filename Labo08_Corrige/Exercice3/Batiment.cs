using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Batiment : IConstructible
    {
        public int Id { get; set; }
        public string Adresse { get; set; }
        public double Superficie { get; set; }

        public Batiment(int id, string adresse, double superficie)
        {
            Id = id;    
            Adresse = adresse;
            Superficie = superficie;
        }

        //redéfiniton de la méthode abstraite
        public virtual void Construire()
        {
            Console.WriteLine($"Construction du batiment ID {Id} situé à {Adresse} d'une superficie de: {Superficie}m^2");
        }
    }
}
