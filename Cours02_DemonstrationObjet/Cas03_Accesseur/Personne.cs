using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas03_Accesseur 
{
    internal class Personne
    {
        //déclaration des attributs
        string nom, prenom;


        //Dfinition des accesseurs pour les attributs
        public string GetNom() { return nom; }
        public string GetPrenom() { return prenom; }



        //Définition des mutateurs (modifier les attributs)
        public void SetNom(string nom) { this.nom = nom; }
        public void SetPrenom(string prenom) { this.prenom = prenom; }
    }
}
