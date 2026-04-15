using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_File
{
    internal class CapteurPression:Capteur
    {
        static Random random = new Random();

        //Constructeur
        public CapteurPression(int id):base(id, "Capteur de pression", "pa") { }

        //redéfiniton de la méthode
        public override void LireValeur()
        {
            ValeurActuelle = random.Next(900, 100) + random.NextDouble(); //Donne un nombre réel entre 900 et 1099 auquel on ajoute une valeur décimale entre 0.0 et 1.0. Ceci permet d'avoir un nombre avec une partie entière entre 900 et 1099 et une pertie décimal entre 0.0 et 1.0

        }
    }
}
