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

        //El siguiente método ya está implementado, pero con virtual hacemos que las clases que implementen esta clase abstracta, pueden realizar una implementación diferente
        public virtual string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la Tierra";
        }
    }
}
