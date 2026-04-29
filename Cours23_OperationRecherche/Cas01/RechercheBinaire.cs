using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class RechercheBinaire : IRecherche
    {
        //Divise une liste triée en deux à chaque étape

        public int Rechercher(List<int> liste, int target)
        {
            //Tri bulles
            for(int i = 0; i < liste.Count - 1; i++)
            {
                for (int j = 0; j < liste.Count - i - 1; j++)
                {
                    if (liste[j] > liste[j + 1])
                        (liste[j], liste[j + 1]) = (liste[j + 1], liste[j]);
                }
            }

            int gauche = 0;
            int droite = liste.Count - 1;

            while (gauche < droite)
            {
                int milieu = (gauche + droite) / 2;

                if (liste[milieu] == target)
                    return milieu;
                else if (liste[milieu] < target)
                    gauche = milieu + 1;
                else
                    droite = milieu - 1;
            }

            return -1;
        }  
    }
}
