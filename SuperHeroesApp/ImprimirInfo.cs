using SuperHeroesApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    internal class ImprimirInfo
    {
        //Utilidad que nos ayudará a imprimir.
        public void ImprimirSuperHeroe( ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe.IdentidadSecreta}");
        }
    }
}
