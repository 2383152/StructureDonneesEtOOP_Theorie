using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class TriFusion : ITrier
    {
        //Divise la liste en deux, trie chaque moitiée et fusionne les résultats
        public List<int> Trier(List<int> liste)
        {
            if(liste.Count <= 1)
                return new List<int>(liste);

            //Dans le cas contraire
            int milieu = liste.Count / 2; //rechercher le milieu

            var gauche = Trier(liste.GetRange(0, milieu)); //GetRange(0, milieu) = retourne une sous-liste à partir d'un indice de départ (donc le 0)  et d'une longueur (milieu)
            var droite = Trier(liste.GetRange(milieu, liste.Count - milieu)); 

            return ListeFusionner(gauche, droite);


        }

        private List<int> ListeFusionner(List<int> gauche, List<int> droite)
        {
            var resultat = new List<int>();

            int i = 0;
            int j = 0;

            while(i < gauche.Count && j < droite.Count)
            {
                if (gauche[i] <= droite[j])
                    resultat.Add(gauche[j++]);
                else
                    resultat.Add(droite[j++]);
            }

            resultat.AddRange(gauche.Skip(i)); //AddRange() = ajoute plusieurs éléments à la suite dans la liste resultat, contrairement à la méthode Add() qui ajoute un seul élément
            resultat.AddRange(droite.Skip(j)); //Skip(j) = méthode qui ignore les j premier éléments de la liste et retourne le reste

            return resultat;
        }
    }
}
