namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création d'un moteur pour un véhciule terrestre
            Moteur moteurTerrestre = new Moteur {TypeMoteur = "Essence", Puissance = 150}; //nouvelle facons d'instancier les attributs de la classe avec le constructeur par défaut

            //Création d'un véhivule terresstre
            VehiculeTerrestre voiture = new VehiculeTerrestre {Vitesse = 120, CapaciteTransport = 5, TypeCarburant = "Essence", Moteur1 = moteurTerrestre}; //attention erreur de ;

            //Création de passager
            Passenger passager1 = new Passenger {Nom = "John", Age = 30};
            Passenger passager2 = new Passenger { Nom = "Lise", Age = 40 };

            //Ajout des passager au vehicule
            voiture.Passager.Add(passager1);
            voiture.Passager.Add(passager2);

            //Afficher détails du véhicule
            voiture.AfficherDetail();
            voiture.Deplacer();
            voiture.Rouler();
            voiture.Moteur1.Demarrer();

        }
    }
}
