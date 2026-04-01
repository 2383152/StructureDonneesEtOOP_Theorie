using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Immeuble : Batiment
    {
        public int NombreEtages { get; set; }

        //attributs ou propriétées provenant de la relation d'association
        List<Machine> MachinesUtilisees { get; set; }

        //Constructeur
        public Immeuble(int id, string adresse, double superficie, int nombreEtage) : base(id, adresse, superficie)
        {
            NombreEtages = nombreEtage;
            MachinesUtilisees = new List<Machine>();
        }

        //Ajouter une machine
        public void AjouterMaachine(Machine machine)
        {
            MachinesUtilisees.Add(machine);
        }

        //Redéfiniton de la méthode Construir
        public override void Construire()
        {
            Console.WriteLine($"Construction d'une maison avec {NombreEtages} pièces, située a {Adresse}, d'une superficie de: {Superficie}m^2");

            if(MachinesUtilisees.Count > 0)
            {
                Console.WriteLine("Machines utilisées pour la construction de l'immeuble");
                foreach(Machine machine in MachinesUtilisees)
                {
                    Console.WriteLine($"--{machine.TypeMachine} (Puissance: {machine.Puissance}KW) ");
                }
            }
            else
            {
                Console.WriteLine("Aucune machine utilisée pour la construction de cette immeuble");
            }
        }
    }
}
