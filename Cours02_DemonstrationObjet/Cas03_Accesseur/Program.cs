namespace Cas03_Accesseur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne personne_01 = new Personne();//fait appek au constructeur par defaut

            //Affection des données
            personne_01.SetNom("LeBlanc");
            personne_01.SetPrenom("Paul");

            //Récuperer le nom et le prenom

            var nom = personne_01.GetNom(); //récupérer le nom
            var prenom = personne_01.GetPrenom();

            Console.WriteLine("\t Nom:" + nom);
            Console.WriteLine("\t Prenom:" + prenom);

        }
    }
}
