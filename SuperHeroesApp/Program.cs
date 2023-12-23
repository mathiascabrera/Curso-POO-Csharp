using System.Text;

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

//Invocación del método
string resultSuperPoderes = superman.UsarSuperPoderes();

Console.WriteLine(resultSuperPoderes);


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

    //Constructor
    public SuperHeroe()
    {
        Id = 1;//Valor por defecto
        SuperPoderes = new List<SuperPoder>();//Inicializamos la Lista de SuperPoderes
        PuedeVolar = false;//Valor por defecto
    }
    //Método
    public string UsarSuperPoderes()
    {
        StringBuilder sb= new StringBuilder();//StringBuilder nos ayuda a concatenar strings
        foreach(var item in SuperPoderes)
        {
            sb.AppendLine($"{Nombre} está usando el super poder {item.Nombre}!!");//AppendLine va concatenando una línea completa de texto y luego nos va a devolver ese Objeto con toda esa información
        }
        return sb.ToString();
    }
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    //Constructor
    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;//Nivel de poder por defecto
    }
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
