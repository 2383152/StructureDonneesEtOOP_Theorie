namespace Cas04_Proprietes
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            DateTime Datenaissance1 = new DateTime(1980, 10, 20);
            Employe employe01 = new Employe(Datenaissance1);
            employe01.Nom = "Laurence";
            employe01.Prenom = "Leblanc";

            //afficher les informations
            employe01.AfficherInformation();


            DateTime Datenaissance2 = new DateTime(1997, 10, 20);
            Employe employe02 = new Employe(Datenaissance2);
            employe01.Nom = "Maude";
            employe01.Prenom = "Lafleur";

            //afficher les informations
            employe02.AfficherInformation();
        }
    }
}
