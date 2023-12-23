using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe
    {
        //public Guid Id;
        public int Id;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} está usando el super poder {item.Nombre}!!");
            }
            return sb.ToString();
        }
    }
}
