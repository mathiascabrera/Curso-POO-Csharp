using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {

        public abstract string Nombre { get; set; }

        public abstract string SalvarElMundo();

        //El siguiente método, al no ser abstracto, las clases que implementen esta clase abstracta, no las tienen que implementar porque ya esta implementada, podrían utilizarla directamente.
        public string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la Tierra";
        }
    }
}
