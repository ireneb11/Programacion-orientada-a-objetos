/*  EJERCICIO 8
  Implementar una clase Personaje que sirva como base para un videojuego 
inspirado en Mario. La clase Personaje debe tener los atributos nombre (string), 
vida (int) y puntos (int), además del método MostrarInfo(), que imprime la 
información del personaje. Crear tres clases derivadas: Mario, que añade el 
atributo poderes (string) para describir sus habilidades especiales; Luigi, que 
incluye el atributo altura (float) para representar su estatura; y Peach, que 
incorpora el atributo tiara (bool) para indicar si lleva puesta su tiara. Cada clase 
derivada debe tener un constructor que inicialice sus atributos.
 
 */
using System;




public class Personaje
{
    // como son propiedades, ponemos la primera en mayuscula
    public string Nombre { get; private set; }  // nombre es private para que no pueda ser modificado desde fuera de la clase.
    public int Vida { get; protected set; }  // puntos y vida son protected para que las clases derivadas puedan modificarlos.
    public int Puntos { get; protected set; }

    // constructor
    public Personaje(string nombre, int vida, int puntos)
    {
        Nombre = nombre;
        Vida = vida;
        Puntos = puntos;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine("Información del personaje: ");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Puntos: {Puntos}");
    }

}

public class Mario : Personaje
{
    private string poderes;

    // constructor
    public Mario(string nombre, int vida, int puntos, string poderes)
      : base(nombre, vida, puntos)
    {
        this.poderes = poderes;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"poderes: {poderes}");
    }
}

public class Luigi : Personaje
{
    public float Altura { get; set; }
    public Luigi(string nombre, int vida, int puntos, float altura)
        : base(nombre, vida, puntos)
    {
        Altura = altura;
    }
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Altura: {Altura} m");
    }
}

public class Peach : Personaje
{
    public bool Tiara { get; set; }
    public Peach(string nombre, int vida, int puntos, bool tiara)
        : base(nombre, vida, puntos)
    {
        Tiara = tiara;
    }
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Tiara: {(Tiara ? "Sí" : "No")}");   // si tiara es = true imprime: Si, si es = false imprima: no
    }
}
