// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;


var superFuerza = new SuperPoder();
poderVolar.Nombre = "Super fuerza";
poderVolar.Nivel = NivelPoder.NivelTres;


var poderMoverseVelLuz = new SuperPoder();
poderMoverseVelLuz.Nombre = "Velocidad luz";
poderMoverseVelLuz.Descripcion = "Moverse a la velocidad de la luz";
poderMoverseVelLuz.Nivel = NivelPoder.NivelTres;


var poderViajeTiempo = new SuperPoder();
poderViajeTiempo.Nombre = "Viajar en el tiempo";
poderViajeTiempo.Nivel = NivelPoder.NivelTres;



var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "SuperMan";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);

superman.SuperPoderes = poderesSuperman;



var flash = new SuperHeroe();
flash.Id = 1;
flash.Nombre = "Flash";
flash.IdentidadSecreta = "Jay Garrick";
flash.Ciudad = "Central City";
flash.PuedeVolar = false;

List<SuperPoder> poderesFlash = new List<SuperPoder>();
poderesFlash.Add(poderMoverseVelLuz);
poderesFlash.Add(poderViajeTiempo);

flash.SuperPoderes = poderesFlash;


//Las Clases deben nombrarse en singular
class SuperHeroe
{
    //public Guid Id;
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
