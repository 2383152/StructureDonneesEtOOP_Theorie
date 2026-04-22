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

        //ajouter un capteur a la file
        public void AjouterCapteur(Capteur capteur)
        {
            fileCapteurs.Enqueue(capteur);

            capteur.LireValeur();

            //Sauvegarde dans le fichier
            File.AppendAllText(fichierCapteurs, capteur.ToFileString + Environment.NewLine);

        }

        //lire et enregistrer une mesure
        public void LireEtEnregistrerMesure()
        {
            if(fileCapteurs.Count == 0)
            {
                Console.WriteLine("Aucun capteur a traiter");

                return;
            }

            //Traiter le capteur le plus ancien (celui arriver en premier, avant l'autre) en premier
            Capteur capteur = fileCapteurs.Dequeue(); //on retire le plus ancien (premier arrivé premier servi)

            //Enregistre dans un fichier
            string ligne = $"{DateTime.Now}: {capteur.ToFileString()}";

            File.AppendAllText(fichierCapteurs, ligne + Environment.NewLine);

            //Ajoute la "ligne" au fichier "fichierCaptuer", puis fait un saut de ligne grâce a "Environment.NewLine". Si le fichier n'existe pas, il le crée

            Console.WriteLine($"Traitement sur la file avec Succes. - {capteur}");
        }

        //Afficher la file des capteurs
        public void AfficherCapteur()
        {
            if (fileCapteurs.Count == 0)
            {
                Console.WriteLine("Aucun capteur enregistré!");
                return;
            }

            Console.WriteLine("Capteurs en attente de traitement dans la file");

            foreach(var capteur in fileCapteurs)
            {
                Console.WriteLine(capteur); //Appel la méthode ToString(). Ressemble a capteur.ToString()
            }
        }
    }
}
