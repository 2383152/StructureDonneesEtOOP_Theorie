namespace Exercice1_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionnaireCapteur gestionnaire = new GestionnaireCapteur();

            while(true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Ajouter un capteur de température");
                Console.WriteLine("2. Ajouter un capteur de pression");
                Console.WriteLine("3. Lire et enregistrer la valeur");
                Console.WriteLine("4. Afficher les capteurs en attente");
                Console.WriteLine("5. Quitter");

                string choix = Console.ReadLine();

                switch(choix)
                {
                    case "1":
                        gestionnaire.AjouterCapteur(new CapteurTemperature(gestionnaire.GetHashCode())); //La méthode  GetHashCode() est une méthode de la classe objet qui renvoie un code hachage (un entier) qui représente un objet de manière unqique.

                        Console.WriteLine("Capteur de température ajouté");

                        break;

                    case "2":
                        gestionnaire.AjouterCapteur(new CapteurTemperature(gestionnaire.GetHashCode())); 

                        Console.WriteLine("Capteur de pression ajouté");

                        break;

                    case "3":
                        Console.WriteLine("Lecture et enregistrement");

                        gestionnaire.LireEtEnregistrerMesure();

                        break;

                    case "4":
                        Console.WriteLine("Liste des capteurs");

                        gestionnaire.AfficherCapteur();

                        break;

                    case "5":
                        Console.WriteLine("Fermeture du programme");

                        break;

                    default:
                        Console.WriteLine("Option Invalide");
                        break;

                }
            }
        }
    }
}
