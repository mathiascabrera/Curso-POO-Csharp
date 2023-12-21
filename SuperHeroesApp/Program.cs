// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "SuperMan";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
superman.SuperPoderes = new[] {"Vision de rayos X","Volar","Super fuerza","Ojos rayos láser"};

var flash = new SuperHeroe();
flash.Id = 1;
flash.Nombre = "Flash";
flash.IdentidadSecreta = "Jay Garrick";
flash.Ciudad = "Central City";
flash.SuperPoderes = new[] {"Moverse a velocidad luz","Resistencia","Viajar en el tiempo"};
flash.PuedeVolar = false;


//Las Clases deben nombrarse en singular
class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public string[] SuperPoderes;
    public bool PuedeVolar;
}
