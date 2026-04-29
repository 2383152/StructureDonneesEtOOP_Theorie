using System.Net.Quic;

namespace Cas01_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemple 1: Divion de deux nombre

            try
            {
                int a = 10;
                int b = 6;

                int resultat = a / b; //Division par 0

                Console.WriteLine(resultat);
            }
            catch(DivideByZeroException execption)
            {
                Console.WriteLine(execption.Message);
            }

            //Exemple 2: wrong entry

            try
            {
                Console.Write("Entrez un nombre: ");
                int nombre = int.Parse(Console.ReadLine());

                Console.WriteLine("nombre entré: " + nombre);
            }
            catch(FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Exemple 3: fichier introuvable

            try
            {
                StreamReader reader = new StreamReader("donnees,txt");
                string contenu = reader.ReadToEnd(); //reader.ReadToEnd(); = lecture jusqu'à la fin du fichier et retourne le contenu sous forme de chaine de caractère
                Console.WriteLine(contenu);
            }
            catch(FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
