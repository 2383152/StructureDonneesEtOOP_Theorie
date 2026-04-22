using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3_Pile
{
    internal class ReactionChimique
    {
        Stack<Reactif> PileReactifs = new Stack<Reactif>();

        //Ajouter a la pile
        public void AjouterReactif(Reactif reactif)
        {
            PileReactifs.Push(reactif); //Push() = ajouter a la pile

            Console.WriteLine($"Ajouter à la pile: {reactif}");
        }

        //Effectuer une réaction chimique (dépiler deux reactifs et produire un produit)
        public void EffectuerReaction()
        {
            if (PileReactifs.Count < 2)
            {
                Console.WriteLine("Pas assez de réactifs pour réagir");
            }

            //Dépiler deux réactifs
            Reactif reactif1 = PileReactifs.Pop(); //Récupère le premier en tête de pile
            Reactif reactif2 = PileReactifs.Pop();
            Console.WriteLine($"Réaction entre {reactif1.Nom}  et {reactif2.Nom}");

            //Simuler la formulation d'un produit
            Produit produit = new Produit("Eau", "H20", "Liquide", 19.02);
            Console.WriteLine($"Produit formé: {produit}");
        }

        public void AfficherReactif()
        {
            Console.WriteLine("Reactifs disponibles dans la pile");

            foreach(var reactif in PileReactifs)
            {
                Console.WriteLine($"{reactif}");
            }
        }
    }
}
