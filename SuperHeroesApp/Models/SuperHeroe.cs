using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe
    {
        private string _Nombre;
        public int Id;
        public override  string Nombre
        { get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();//El método trim elimina los espacios del principio y del final de la cadena.
            }
        }

        public string NombreIdentidadSecreta
        {
            get
            {
                return $"{_Nombre} ({IdentidadSecreta})";
            }
        }

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
                sb.AppendLine($"{NombreIdentidadSecreta} está usando el super poder {item.Nombre}!!");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreIdentidadSecreta} ha salvado el mundo.";
        }
        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreIdentidadSecreta} ha salvado la Tierra.";
        }
    }
}
