namespace Exercice3_Pile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReactionChimique reaction = new ReactionChimique();

            //Ajouter des réactifs
            reaction.AjouterReactif(new Reactif("Hydrohgène", "H2", "Gaz", 2.02, "Inflammable"));
            reaction.AjouterReactif(new Reactif("Oxygène", "02", "Gaz", 2.02, "Supporte la combustion"));

            //Afficher les réactifs en attente
            reaction.AfficherReactif();

            //Effectuer les réactions chimiques
            reaction.EffectuerReaction();
        }
    }
}
