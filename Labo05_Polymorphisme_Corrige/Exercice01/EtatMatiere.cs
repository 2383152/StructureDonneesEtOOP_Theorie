using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class EtatMatiere
    {
        string nom;
        public EtatMatiere(string nom)
        {
            this.nom = nom;
        }

        //Méthode pour changer l'état de la matière

        //La méthode ChangerEtat sert à laisser chaque type de matière décider lui-même comment il change selon la température!!
        //le virtal sert a dire que toutes les classes dérivées auront cette méthode
        //My guess is that we have to create virtual and override classes so that we can cross reference between all 3 derived classes of the EtatMatiere
        public virtual EtatMatiere ChangerEtat(double temperature)
        {
            return this; //on dit donc que par defaut, rien ne change. return this = “je reste le même objet, je ne change pas d’état”
        }

        public void AfficherEtat()
        {
            Console.WriteLine($"L'état actuel est: {nom}");
        }
    }
}
