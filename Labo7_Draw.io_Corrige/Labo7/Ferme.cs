using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo7
{
    internal class Ferme
    {
        int nombreAnimaux = 0;
        List<Animal> ListeAnimaux = new List<Animal>();
        public void AjouterAnimal(Animal animaux)
        {
            ListeAnimaux.Add(animaux);
        }

        public void EcouterAnimal()
        {
            // aller dans Class dans list et fait ça
            foreach (var animal in ListeAnimaux)
            {
                animal.PousserCri();
            }
        }
    }
}
