
/* EJERCICIO 5
  Construir una definición de clase que se pueda utilizar para representar un coche 
de una compañía. La clase coche contiene los atributos color, motor y 
velocidadMáxima. La clase puede agrupar las operaciones arrancar, acelerar y 
frenar. Cree tres objetos de la clase. 
 */

using System;


class Coche
{
    // atributos
    private string color, motor;
    private float velocidadMaxima;
    private float velocidadActual;
    private bool arrancar;


    // constructor
    public Coche(string color, string motor, float velocidadMaxima)
    {
        this.color = color;
        this.motor = motor;
        this.velocidadMaxima = velocidadMaxima;
        arrancar = false;
    }

    public void Arrancar()
    {
        if (arrancar)
        {
            Console.WriteLine("El coche ya está arrancado");


        }
        else
        {
            arrancar = true;
            Console.WriteLine("Arrancando...");
        }
    }

    public void acelerar(float velocidadDestino)
    {
        if (arrancar)
        {
            if (velocidadDestino < velocidadMaxima)
            {
                if (velocidadActual < velocidadDestino)
                {
                    velocidadActual = velocidadDestino;
                    Console.WriteLine("Acelerando...");
                }
                else
                {
                    Console.WriteLine("La velocidad a la que quiere llegar está por debajo de la actual");
                }

            }
            else
            {
                Console.WriteLine("La velocidad a la que quiere llegar supera los limites");
            }
        }
        else
        {
            Console.WriteLine("El coche no está en marcha");
        }


    }


    public void frenar()
    {
        if (arrancar)
        {
            if (velocidadActual > 0f)
            {             
                velocidadActual = 0.0f;
                Console.WriteLine("Frenando...");
                
            }
            else
            {
                Console.WriteLine("El coche ya está parado");
            }
        }
        else
        {
            Console.WriteLine("El coche no está en marcha");
        }


    }
}



public class Program
{
    static void Main(string[] arg)
    {
        Coche c1 = new Coche("verde", "clasic 0012", 7999.35f);
        Coche c2 = new Coche("rojo", "clasic 911", 8999.35f);
        Coche c3 = new Coche("azul", "clasic 911", 8999.35f);

        Console.WriteLine("Coche 1:");
        c1.Arrancar();
        c1.acelerar(100f);
        c1.frenar();
        c1.frenar();

        Console.WriteLine("\nCoche 2:");
        c2.acelerar(8999.35f);
        c2.Arrancar();
        c2.acelerar(8999.35f);
        c2.frenar();

        Console.WriteLine("\nCoche 3:");
        c3.frenar();
        c3.Arrancar();
        c3.acelerar(9000f);
        c3.acelerar(8000f);
        c3.acelerar(100f);

    }

}

