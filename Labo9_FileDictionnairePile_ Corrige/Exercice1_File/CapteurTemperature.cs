using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_File
{
    internal class CapteurTemperature:Capteur
    {
        static Random random = new Random();

        //Constructeur
        public CapteurTemperature(int id) : base(id, "Capteur de température", "°C") { }

        //redéfiniton de la méthode
        public override void LireValeur()
        {
            ValeurActuelle = random.Next(-10, 40) + random.NextDouble(); 
        }
    }
}
