using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class Recherche
    {
        public static void Test(IRecherche algorithmeRecherche, List<int> liste, int target, string name)
        {
            int index = algorithmeRecherche.Rechercher(new List<int>(liste), target); //copie pour ne pas modifier l'original

            if(index != -1)
                Console.WriteLine($"{name}: Élément trouvé à l'indice {index}");
            else
                Console.WriteLine($"{name}: Élément non trouvé");
        }
    }
}
