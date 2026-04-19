using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Machine
    {
        public int Id { get; set; }
        public string TypeMachine {  get; set; }
        public double Puissance { get; set; }

        public Machine(int id, string typeMachine)
        {
            Id = id; 
            TypeMachine = typeMachine;
        }

        public void Utiliser()
        {
            Console.WriteLine($"La machine {TypeMachine} (ID: {Id}) est en fonctionnement avec une puissance de {Puissance}KW");
        }
    }
}
