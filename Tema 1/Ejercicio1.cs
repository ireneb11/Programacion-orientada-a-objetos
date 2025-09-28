using System;


/* EJERCICIO 1
Un usuario le solicita desarrollar un programa que modele el comportamiento de
una Persona. Esta persona viene definida por un nombre, y además, puede
dormir (diría “zzz zzz zzz”), hablar (diría “bla bla bla”), contar (diría “1 2 3 4 …”),
recibir un nombre, e incluso decir su nombre. Modele e implemente la clase
necesaria para resolver este programa. Defina un método principal donde se
prueben los métodos de la clase implementada.

ademas incluya metodos get y set para el nombre

*/

public class Persona
{
    //Atributos
    private string? nombre;
    private int i;

    // CONSTRUCTOR
    public Persona(string nombre)
    {
       this.nombre = nombre;
        
    }

    //Metodo para que la persona duerma
    public void dormir()
    {
        Console.WriteLine("zzz zzz zzz");
    }

    //Metodo para que la persona hable
    public string hablar()
    {
        return "bla bla bla";
    }

    //Metodo para que la persona cuente desde 1 hasta un numero dado
    public void contarNumeros(int numero)
    {
        for (i = 1; i <= numero; i++)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine();
    }

    //Metodo para modificar el nombre de la persona
    public void setNombre(string nuevoNombre)
    {
        nombre = nuevoNombre;
    }

    //Metodo para consultar el nombre de la persona
    public void getNombre()
    {
        Console.WriteLine("Mi nombre es: " + nombre);
    }
}






public class Program
{
    static void Main(string[] args)
    {
        Persona P1 = new Persona("Pepe");
        P1.setNombre("Luis");
        P1.getNombre();
        P1.dormir();  // no devuelve nada, ya lo imprimedentro del método
        Console.WriteLine(P1.hablar()); // como hablar devuelve un string, hay que poner Console.WriteLine
        P1.contarNumeros(17);
    }

}

  

