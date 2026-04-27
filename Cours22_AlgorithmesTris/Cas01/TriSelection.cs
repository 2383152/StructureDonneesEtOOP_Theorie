using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class TriSelection : ITrier
    {
        //Trouve le plus petit élément de la liste et la place au début, puis continue avec le reste de la liste

        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);

            for (int i = 1; i < resultat.Count - 1; i++)
            {
                int indexMinimum = i;
                for(int j = i + 1; j < resultat.Count; j++)
                {
                    if (resultat[j] < resultat[indexMinimum])
                        indexMinimum = j;
                }

                //Permutation
                (resultat[i], resultat[indexMinimum]) = (resultat[indexMinimum], resultat[i]);
            }

            return resultat;
        }
    }
}
