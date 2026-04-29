using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class RechercheLineaire : IRecherche
    {
        //Parcourt la liste élément par élément

        public int Rechercher(List<int> liste, int target)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i] == target)
                    return i;          
            }
            return -1;

        }
    }
}
