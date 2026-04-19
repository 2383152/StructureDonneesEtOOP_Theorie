using System;

namespace Labo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferme FermeAntoine = new Ferme();

            FermeAntoine.AjouterAnimal(new Poussin());
            FermeAntoine.AjouterAnimal(new Chat());
            FermeAntoine.AjouterAnimal(new Vache());
            FermeAntoine.AjouterAnimal(new Poussin());

            FermeAntoine.EcouterAnimal();
        }
    }
}
