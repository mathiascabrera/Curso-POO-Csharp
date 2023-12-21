// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Tenemos dos formas de crear un Objeto: var que representa cualquier tipo de datos que vayamos a crear y C# lo va a interpretar de manera automática, la otra forma es especificar directamente el tipo.

Apuntador apuntadorSony = new Apuntador();
//new es la palabra reservada que nos permite crear un objeto a partir de una clase.


//Podemos crear múltiples objetos
Apuntador apuntadorSony2 = new Apuntador();

//A esto se refiere la POO con reutilizar, con crear una única plantilla base e ir reutilizando poco a poco ese mismo código que hemos implementado. 



//Asignamos valores a las propiedades:

apuntadorSony.Color = "Negro";
apuntadorSony2.Color = "Blanco";



//Una clase es un molde para crear múltiples Objetos
class Apuntador
{
    //Creamos características generales o variables, no específicas del Objeto
    //Las características que representemos en una Clase se denominan Propiedades
    public string Color;
    public double Largo;//Medida del largo del Apuntador
    public short NumeroDeBotones;//Short es entero corto
    public bool TieneStickers;

}