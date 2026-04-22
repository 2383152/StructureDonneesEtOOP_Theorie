using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2_Dictionnaire
{
    internal class GestionnaireSubstance
    {
        Dictionary<string, List<Substance>> DictionnaireSubstance;

        public GestionnaireSubstance()
        {
            DictionnaireSubstance = new Dictionary<string, List<Substance>>();
        }

        //Ajouter une substance dasn le dictionnaire
        public void AjouterSubstance(Substance substance)
        {
            string typeSubstance = substance.GetType().Name; //retourne le type d'objet

            if (!DictionnaireSubstance.ContainsKey(typeSubstance)) //Si la clé n'existe pas, alors il va la créer
            {
                DictionnaireSubstance[typeSubstance] = new List<Substance>(); //Création d'une nouvelle liste
            }

            //Ajout de la substance dans la clé appropriée
            DictionnaireSubstance [typeSubstance].Add(substance);
            Console.WriteLine($"Substance {substance.Nom} ajoutée sous la catégorie {typeSubstance}");
        }

        //Méthode pour les réactions chiiuqes des substances d'un type donné
        public void EffectuerReactionParType(string typeSubstance)
        {
            if(DictionnaireSubstance.ContainsKey(typeSubstance))
            {
                Console.WriteLine($"Réaction des {typeSubstance}s : ");

                foreach(var substance in DictionnaireSubstance[typeSubstance])
                {
                    substance.Reagir();
                }
            }
            else
            {
                Console.WriteLine($"Aucune substance trouvé pour le type {typeSubstance}");
            }
        }

    }
}
