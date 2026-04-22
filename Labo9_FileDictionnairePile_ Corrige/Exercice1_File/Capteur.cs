using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_File
{
    internal abstract class Capteur
    {
        public int ID { get; set; }
        public string Nom {  get; set; }
        public string UniteMesure { get; set; }
        public double ValeurActuelle { get; set; }

        //Constructeur
        public Capteur(int id, string nom, string unite)
        {
            ID = id;
            Nom = nom;
            UniteMesure = unite;
        }

        //Méthode abstraite 
        public abstract void LireValeur();

        //redéfinition de la méthode toString()
        public override string ToString()
        {
            return $"{Nom} (Id: {ID}) - Derniére valeur: {ValeurActuelle} {UniteMesure}";
        }

        //Méthode pour convertir un capteur en format de fichier, pour l'enregistrement
        public string ToFileString()
        {
            return $"{ID}; {Nom}; {UniteMesure}; {ValeurActuelle}";
        }
    }
}
