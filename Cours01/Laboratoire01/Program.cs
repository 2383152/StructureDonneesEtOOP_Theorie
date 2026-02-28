//Laboratoire 1

//fonction menu
char Menu()
{
    Console.WriteLine("voulez-vous continuer (O/N)?:");

    char choix;
    choix = char.Parse(Console.ReadLine());
    return char.ToUpper(choix); //conversion en majuscule
}

//fonction ecran de bienvenue
void EcranBienvenue()
{
    Console.Clear(); //efface l'écran

    Console.WriteLine("-----------Laboratoir 1--------------");
    Console.WriteLine("-----------Bienvenu dans le magasin--------------");
    Console.WriteLine("-----------Fichier de facturation--------------");
    Console.WriteLine("-----------du magasin d'électronique--------------");
    Console.WriteLine("-----------vivre a la moderne--------------");
}

//fonction pour calculer le cout avant le rabais
int CalculerCoutAvanRabais(int nombrearticle, int coutUniter)
{
    return nombrearticle * coutUniter;
}

//fonction pour calculer le cout après le rabais
float CalculerCoutApreRabais(float montant, float pourcentageRabais)
{
    return montant - (montant * pourcentageRabais);
}

//fonction pour calculer la tps
float CalculerTPS(float montantApresRabais, float tauxTPS)
{
    return tauxTPS * montantApresRabais;
}

//fonction pour calculer la tvq
float CalculerTVQ(float montantApresRabais, float tauxTVQ)
{
    return tauxTVQ * montantApresRabais;
}

//calculer le pourcentage de réduction
float CalculerPourcentageReduction(char categorie, int nombreArticle, int coutUniter)
{
    int valeur;
    float pourcentageRabais;
    valeur = CalculerCoutAvanRabais(nombreArticle, coutUniter);

    switch (categorie)
    {
        case 'R':
        case 'r':
            if (valeur >= 250 && valeur < 500)
                pourcentageRabais = 0.25f; //f = float
            else if (valeur >= 500)
                pourcentageRabais = 0.30f;
            else
                pourcentageRabais = 0.050f;
            break;

        case 'T':
        case 't':
            if (valeur <= 500)
                pourcentageRabais = 0.40f;
            else
                pourcentageRabais = 0.50f;
            break;

        default:
            pourcentageRabais = 0.20f;
            break;
    }

    return pourcentageRabais;
}

//fonction pour afficher sur la console

void AfficherFacture(string nom, string prenom, char categorie, float pourcentageRabais, float sommeAvantRabais, float sommeApresRabais, float sommeTPS, float sommeTVQ, float sommeTotal, int nombreArticle)
{
    Console.WriteLine(string.Format("{0, -20}:{1,20}", "NOM", nom));
    Console.WriteLine(string.Format("{0, -20}:{1,20}", "PRÉNOM", prenom));
    Console.WriteLine(string.Format("{0, -20}:{1,20}", "CATEGORIE", nom));
    Console.WriteLine(string.Format("{0, -20}:{1,20}{2}", "POURCENTAGE RABAIS", pourcentageRabais, "$"));
    Console.WriteLine(string.Format("{0, -20}:{1,20}{2}", "SOMME AVANT RABAIS", sommeAvantRabais, "$"));
    Console.WriteLine(string.Format("{0, -20}:{1,20}{2}", "SOMME APRÈS RABAIS", sommeApresRabais, "$"));
    Console.WriteLine(string.Format("{0, -20}:{1,20}{2}", "SOMME TPS", sommeTPS, "$"));
    Console.WriteLine(string.Format("{0, -20}:{1,20}{2}", "SOMME TPS", sommeTVQ, "$"));
    Console.WriteLine(string.Format("{0, -20}:{1,20}{2}", "TOTAL", sommeTotal, "$"));

    // Sauvegarde dans un fichier txt

    StreamWriter fichier = new StreamWriter("Facture.txt", true); // pour l'ouvrir en ecriture et en ajout

    fichier.WriteLine(string.Format("{0,-20}:{1,20}", "NOM", nom));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}", "PRENOM", prenom));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}", "CATEGORIE", categorie));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}{2}", "POURCENTAGE RABAIS", pourcentageRabais, "$"));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}{2}", "SOMME AVANT RABAIS", sommeAvantRabais, "$"));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}{2}", "SOMME APRES RABAIS", sommeApresRabais, "$"));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}{2}", "SOMME TPS", sommeTPS, "$"));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}{2}", "SOMME TVQ", sommeTVQ, "$"));
    fichier.WriteLine(string.Format("{0,-20}:{1,20}{2}", "TOTAL", sommeTotal, "$"));
}





//Début du programme principal
int nombreArticle;
float sommeApresRabais, sommeTVQ, sommeTPS, pourcentage, sommeAvantRabais, sommeTotal;
string nom, prenom;
char categorie;

const int coutUniter = 20;
const float tauxTPS = 0.5f;
const float tauxTVQ = 0.0975f;

char choix = 'O';

do
{
    EcranBienvenue();
    Console.Write("Veuillez entrer votre nom: ");
    nom = Console.ReadLine();

    Console.Write("Veuillez entrer votre prénom: ");
    prenom = Console.ReadLine();

    Console.Write("Veuillez entrer le nombre d'article: ");
    nombreArticle = int.Parse(Console.ReadLine());

    Console.Write("Veuillez entrer votre catégorie (entrer une lettre R, T ou C): ");
    categorie = char.Parse(Console.ReadLine());

    //opération de calcul
    sommeAvantRabais = CalculerCoutAvanRabais(nombreArticle, coutUniter);
    pourcentage = CalculerPourcentageReduction(categorie, nombreArticle, coutUniter);
    sommeApresRabais = CalculerCoutApreRabais(sommeAvantRabais, pourcentage);

    sommeTPS = CalculerTPS(sommeApresRabais, tauxTPS);
    sommeTVQ = CalculerTVQ(sommeApresRabais, tauxTVQ);
    sommeTotal = sommeTPS + sommeTVQ + sommeApresRabais;

    AfficherFacture(nom, prenom, categorie, pourcentage, sommeAvantRabais, sommeApresRabais, sommeTPS, sommeTVQ, sommeTotal, nombreArticle);
    choix = Menu();
} while (choix != 'N');

Console.WriteLine("Merci pour votre visite");
Console.ReadKey();


