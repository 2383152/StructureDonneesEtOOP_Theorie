using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_File
{
    internal class GestionnaireCapteur
    {
        Queue<Capteur> fileCapteurs = new Queue<Capteur>();
        string fichierCapteurs = "Capteur_File.txt";

        //Constructeur
        public GestionnaireCapteur() 
        {
            ChargerCapteurDepuisFichier();
        }

        private void ChargerCapteurDepuisFichier()
        {
            if (!File.Exists(fichierCapteurs)) 
                return; //Verifie si le fichier spécifique existe. Si ce n'est pas le cas, termine imétiatement

            string[] lignes = File.ReadAllLines(fichierCapteurs);

            foreach(string ligne in lignes)
            {
                string[] elements = ligne.Split(';');

                if(elements.Length >= 3)
                {
                    int id = int.Parse(elements[0]);
                    string nom = elements [1];

                    if(nom.Contains("Temperature")) //vérifie si la chaine de caractère est contenue dans la variable nom, contient la sous-chaine "Température"
                    {
                        fileCapteurs.Enqueue(new CapteurTemperature(id)); //ajoute a la file
                    }

                    else if (nom.Contains("Pression"))
                    {
                        fileCapteurs.Enqueue(new CapteurPression(id));
                    }
                }
            }
        }
    }
}
