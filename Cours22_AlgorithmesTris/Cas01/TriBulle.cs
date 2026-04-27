using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class TriBulle : ITrier
    {
        //Compare les éléments adjacent et les échanges s'ils sont dans le mauvais ordre et répète le processis jusqu'à ce que la liste soit triée

        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);

            for (int i = 1; i < resultat.Count - 1; i++)
            {
                for(int j = 0; j < resultat.Count - i - 1; j++)
                {
                    if (resultat[j] >  resultat[j+1])
                    {
                        //Permutation des valeurs
                        (resultat[j], resultat[j + 1]) = (resultat[j+1], resultat[j]);//Affectation en tuple, cei équivaut à: int temp = resultat[j];
                                                                                                                           // resulat[j] = resultat[j+1];
                                                                                                                           // resultat[j+1] = temp;                      
                    }
                }
            }

            return resultat;
        }
    }
}
