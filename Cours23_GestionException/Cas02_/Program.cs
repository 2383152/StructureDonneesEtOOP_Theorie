using Cas02_Throw;

namespace Cas02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--Résolution d'une équation de second degrée--");
                Console.Write("Entrez le coefficient a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Entrez le coefficient b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Entrez le coefficient c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                EquationSecondDegree equation = new EquationSecondDegree(a, b, c);
                equation.Resoudre();
            }
            catch(FormatException excepion)
            {
                Console.WriteLine(excepion.Message);
            }
            catch(ResolutionException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Erreur inattendu" + exception.Message); // est utilisé pour capter toutes les erreurs non-spécifiée dans le bloc catch
            }
            

        }
    }
}
