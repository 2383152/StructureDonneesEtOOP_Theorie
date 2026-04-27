using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01
{
    internal class MenuPrincipal
    {
        public static ITrier VotreChoix(int choix)
        {
            switch(choix)
            {
                case 1:
                    return new TriBulle();

                case 2:
                    return new TriInsertion();

                case 3:
                    return new TriRapide();

                case 4:
                    return new TriSelection();

                case 5:
                    return new TriFusion();

                default:
                    Console.WriteLine("Choix invalide");
                    return null;
            }
        }
    }
}
