using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class TriRapide : ITrier
    {
        //Choisit un pivot, partionne les éléments autour de ce pivot et trie recursivement les sous liste
        //On choisit un élément du tableau comme pivot, tous les éléments plus petit que le pivot vont à gauche et tous ceux qui sont plus grand vont à droite et applique la récursivité sur le sous-tableaux

        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);

            TrierRapidement(resultat, 0, resultat.Count - 1);

            return resultat;

        }

        private void TrierRapidement(List<int> resultat, int gauche, int droite)
        {
            if(gauche < droite)
            {
                int pivot = Partitioner(resultat, gauche, droite);

                TrierRapidement(resultat, gauche, pivot - 1); //Récursivité
                TrierRapidement(resultat, pivot + 1, droite);
            }
        }

        private int Partitioner(List<int> resultat, int gauche, int droite)
        {
            int pivot = resultat[droite];
            int i = gauche - 1;

            for(int j = gauche; j < droite; j++)
            {
                if (resultat[j] < pivot)
                {
                    i++;

                    //Permutation
                    (resultat[i], resultat[j]) = (resultat[j], resultat[i]);
                }
            }

            (resultat[i+1], resultat[droite]) = (resultat[droite], resultat[i+1]);

            return i + 1;
        }
    }
}
