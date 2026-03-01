using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas02_SurchargeMethodes
{
    internal class Calcul //Retranscrit dans notes perso
    {
        int x, y, z;

        //Définition de la méthode pour additionner deux paramètres
        public int Additionner(int x, int y)
        { return x + y; }

        //Définition de la méthode pour additionner trois paramètres
        public int Additionner(int x, int y, int z) //différence de type de parametres ou de nombre de parametre (surcharge de methode)
        { return x + y + z; }

        public float Additionner(float p, float k)
        { return p + k; }
    }
}
