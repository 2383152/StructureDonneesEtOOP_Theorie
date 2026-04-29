using Cas02_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas02_Throw
{
    internal class EquationSecondDegree
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public EquationSecondDegree(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void Resoudre()
        {
            if(A == 0)
            {
                Console.WriteLine("Ce n'est pas une équation du second degrée");
                return;
            }

            //Calcul du discriminant
            double delta = (B * B) - 4 * A * C;

            Console.WriteLine("Discriminant: " + delta);
            if(delta < 0)
            {
                throw new ResolutionException(); //throw = permet de lancer une exception sur ma propre classe Exception 
            }
            else if(delta == 0)
            {
                double x = -B / (2 * A);

                Console.WriteLine("Une seule solution réelle" + x);
            }
            else
            {
                double racineDelta = Math.Sqrt(delta);
                double x1 = (-B - racineDelta) / (2 * A);
                double x2 = (-B + racineDelta) / (2 * A);

                Console.WriteLine("Deux solutions réelles: x1 = " + x1 + ", x2 = " + x2);
            }
        }
    }
}
