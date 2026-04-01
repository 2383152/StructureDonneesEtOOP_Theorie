using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Passenger
    {
        public string Nom { get; set;  } //sert accédée la propriété a l'extérieur de la classe, si juste string nom: peut pas accédé a l'extérieur 
        public int Age { get; set;  }//set; sert a le modifier quand on créer une instance

        //Définition des méthodes
        public void Ambarquer()
        {
            Console.WriteLine($"{Nom} embarque a bord");
        }

        public void Desembarquer()
        {
            Console.WriteLine($"{Nom} débarque");
        }
    }
}
