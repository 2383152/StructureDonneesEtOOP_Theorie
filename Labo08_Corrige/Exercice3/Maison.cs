using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Maison : Batiment
    {
        public int NombrePieces { get; set; }

        public Maison(int id, string adresse, double superficie, int nombrePieces) : base(id, adresse, superficie) 
        {
            NombrePieces = nombrePieces;
        }

        public override void Construire()
        {           
            Console.WriteLine($"Construction d'une maison avec {NombrePieces} pièces, située a {Adresse}, d'une superficie de: {Superficie}m^2");      
        }


        
    }
}
