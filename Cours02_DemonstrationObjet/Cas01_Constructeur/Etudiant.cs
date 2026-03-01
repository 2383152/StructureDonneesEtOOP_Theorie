using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas01_Constructeur //Retranscrit
{
    internal class Etudiant
    {
        //Déclaration des attributs (variables) de la classe
        private string nom;
        private int age;
        private string prenom;
        private string departement;


        //Définition du constructeur pour initialiser les attributs de la classe
        public Etudiant(string nom_1, string prenom_1, string departement_1, int age_1)
        {
            this.nom = nom_1;
            departement = departement_1;
            age = age_1;
        }

        //Méthode (fonction) pour afficher les informations d'un étudiant
        public void AfficherInfo()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Prénom: {prenom}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Département: {departement}");

        }

    }
}
