using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal abstract class Forme //les classe abstraite ne peuvent pas avoir d'instance, elles peuvent seulement être hérité, mais je peux qd mm l'utiliser comme type (ex: list<Forme>)
    {
        public abstract double CalculerAire(); //les méthodes abstraites ne peuvent pas contenir de corps, donc elles doivent absolument seulement être override
        
    }
}
