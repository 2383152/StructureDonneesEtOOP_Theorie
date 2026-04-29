namespace Cas01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int> { 9, 3, 7, 1, 5, 8 };

            int valeurRecherchee = 5;

            IRecherche lineaire = new RechercheLineaire();
            IRecherche binaire = new RechercheBinaire();
            IRecherche dictionnaire = new RechercheDictionnaire(liste);

            Console.WriteLine("Liste " + string.Join(" ", liste));
            Console.WriteLine("Recherche de la valeur: " + valeurRecherchee);

            Recherche.Test(lineaire, liste, valeurRecherchee, "Recherche linéaire");
            Recherche.Test(binaire, liste, valeurRecherchee, "Recherche binaire");
            Recherche.Test(dictionnaire, liste, valeurRecherchee, "Recherche dictionnaire");
        }
    }
}
