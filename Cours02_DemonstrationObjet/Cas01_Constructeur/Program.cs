namespace Cas01_Constructeur
{
    internal class Program //Retranscrit 
    {
        static void Main(string[] args)
        {
            string nom;
            Console.Write("Entrez votre nom: ");
            nom = Console.ReadLine();

            string prenom;
            Console.Write("Entrez votre prenom: ");
            prenom = Console.ReadLine();

            string departement;
            Console.Write("Entrez votre département: ");
            departement = Console.ReadLine();

            int age;
            Console.Write("Entrez votre age: ");
            age = int.Parse(Console.ReadLine());


            //instanciation d'un objet de type Étudiant (déclaration d'une variable de type étudiant)
            Etudiant eleve01 = new Etudiant("Jean", "Paul", "Mécanique", 20); //appel du constructur pour initialiser les attributs de la classe

            // appel de la méthode pour afficher un étudiant
            eleve01.AfficherInfo();
        }
    }
}
