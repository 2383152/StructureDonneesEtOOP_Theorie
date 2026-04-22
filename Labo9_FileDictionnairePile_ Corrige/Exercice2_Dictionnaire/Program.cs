namespace Exercice2_Dictionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionnaireSubstance gestionnaire = new GestionnaireSubstance();

            //Création des substances chimiques

            Acide acide1 = new Acide(1, "Acide Chlorydrique", "HCL");
            Acide acide2 = new Acide(2, "Acide Sulfirique", "H2SO4");

            Base base1 = new Base(3, "Soude", "NaOH");

            Gaz gaz1 = new Gaz(4, "Oxygène", "O2");

            Metal metal1 = new Metal(5, "Fer", "Fe");
            Metal metal2 = new Metal(6, "Zinc", "Zn");

            //Ajout des substances au Dictionnaire
            gestionnaire.AjouterSubstance(acide1);
            gestionnaire.AjouterSubstance(acide2);
            gestionnaire.AjouterSubstance(base1);
            gestionnaire.AjouterSubstance(gaz1);
            gestionnaire.AjouterSubstance(metal1);
            gestionnaire.AjouterSubstance(metal2);

            //Simulation des réactions
            gestionnaire.EffectuerReactionParType("Acide");
            gestionnaire.EffectuerReactionParType("Base");
            gestionnaire.EffectuerReactionParType("Gaz");
            gestionnaire.EffectuerReactionParType("Metal");
            gestionnaire.EffectuerReactionParType("Liquide");


        }
    }
}
