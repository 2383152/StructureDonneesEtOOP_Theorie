using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class RechercheDictionnaire : IRecherche
    {
        //recherche par la clé

        private Dictionary<int, int> dictionnaire;

        //Constructeur qui fait en mm temps le transfert dans un dictionnaire
        public RechercheDictionnaire(List<int> liste)
        {
            dictionnaire = new Dictionary<int, int>();

            for(int i = 0; i < liste.Count; i++)
            {
                if (!dictionnaire.ContainsKey(liste[i]))
                    dictionnaire.Add(liste[i], i);
            }
        }

        //Méthode de recherche
        public int Rechercher(List<int> liste, int target)
        {
            if (dictionnaire.ContainsKey(target))
                return dictionnaire[target];

            return -1;
        }
    }
}
