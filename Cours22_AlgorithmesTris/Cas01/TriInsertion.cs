using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class TriInsertion : ITrier
    {
        //Insère chaque élément a sa place dans une sous liste déjà triée

        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);

            for (int i = 1; i < resultat.Count; i++)
            {
                int clé = resultat[i];

                int j = i - 1;

                while (j >= 0 && resultat[j] > clé)
                {
                    resultat[j+1] = resultat[j];
                    j--;
                }

                resultat[j + 1] = clé;
            }

            return resultat;
        }
    }
}
