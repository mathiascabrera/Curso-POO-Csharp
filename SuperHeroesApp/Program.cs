using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Interface;
using SuperHeroesApp.Models;

var imprimirInfo = new ImprimirInfo();

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;


var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;


var poderMoverseVelLuz = new SuperPoder();
poderMoverseVelLuz.Nombre = "Velocidad luz";
poderMoverseVelLuz.Descripcion = "Moverse a la velocidad de la luz";
poderMoverseVelLuz.Nivel = NivelPoder.NivelTres;


var poderViajeTiempo = new SuperPoder();
poderViajeTiempo.Nombre = "Viajar en el tiempo";
poderViajeTiempo.Nivel = NivelPoder.NivelTres;


var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Nivel = NivelPoder.NivelTres;



var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "    SuperMan   ";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;



List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);

superman.SuperPoderes = poderesSuperman;

//Invocación del método
string resultSuperPoderes = superman.UsarSuperPoderes();

Console.WriteLine(resultSuperPoderes);




var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);

wolverine.SuperPoderes = poderesWolverine;

//Invocación del método
string resultWolverinePoderes = wolverine.UsarSuperPoderes();

Console.WriteLine(resultWolverinePoderes);

string accionAntiHeroe = wolverine.RealizarAccionDeAntiHeroe("Atacar la Policía");
Console.WriteLine(accionAntiHeroe);

string resultSalvarMundo = wolverine.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

//Hacemos uso del método implementado en la clase abstracta.
string resultSalvaTierra = wolverine.SalvarLaTierra();
Console.WriteLine(resultSalvaTierra);

//Prueba uso Interface
imprimirInfo.ImprimirSuperHeroe(wolverine);

Console.WriteLine($"Resultado de aplicar el método en la interface: {((ISuperHeroe)wolverine).GetSuperHeroe()}");


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


enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

//Creamos un Record
//No podemos tener dos tipos con el mismo nombre
public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);
