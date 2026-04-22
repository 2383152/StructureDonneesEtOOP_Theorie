using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2_Dictionnaire
{
    internal abstract class Substance
    {
        public int Id { get; set; } 
        public string Nom {  get; set; }
        public string Formule { get; set; }
        public string Etat { get; set; }

        public Substance(int id, string nom, string formule, string etat)
        {
            Id = id;
            Nom = nom;
            Formule = formule;
            Etat = etat;
        }

        //Méthode abstraite
        public abstract void Reagir();
    }
}
