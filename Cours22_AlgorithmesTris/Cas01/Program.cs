namespace Cas01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir les données de la liste");

            var input = Console.ReadLine(); //Séparer par des espaces

            var data = input.Split(' ').Select(int.Parse).ToList(); // ToList() = Conversion de la séquance d'entiers en une liste
                                                                    // Select(int.Parse) = int.Parse = converti la chaine de caractère en entiers

            Console.WriteLine("Choisissez un algorythme de tri: ");
            Console.WriteLine("1: Tri bulle");
            Console.WriteLine("2: Tri insertion");
            Console.WriteLine("3: Tri rapide");
            Console.WriteLine("4: Tri selection");
            Console.WriteLine("5: Tri fusion");

            Console.WriteLine("Votre choix (1 - 5): ");
            int choix = int.Parse(Console.ReadLine());

            ITrier algorythme = MenuPrincipal.VotreChoix(choix); //Appel de la méthode statique


            List<int> listeTrier = algorythme.Trier(data);

            Console.WriteLine("Voici votre liste triée");
            Console.WriteLine(string.Join(" ", listeTrier));


        }
    }
}
