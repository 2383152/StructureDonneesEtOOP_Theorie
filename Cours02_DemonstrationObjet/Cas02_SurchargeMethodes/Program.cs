namespace Cas02_SurchargeMethodes
{
    internal class Program
    {
        static void Main(string[] args) //Retrancrit en note personel
        {
            Calcul calcul1 = new Calcul(); //Appel du constructeur par défaut

            //Appel de la méthode pour additionner deux parametres
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7, 8)}");
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7, 8, 9)}");
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7.5f, 8.1f)}");
        }
    }
}
