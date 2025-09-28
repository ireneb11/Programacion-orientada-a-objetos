using System;

/* EJERCICIO 2
 Representar una clase ascensor (elevador) que tenga las funciones usuales de 
subir, bajar, parar entre niveles (pisos), alarma, sobrecarga y en cada nivel (piso) 
botones de llamada para subir o bajar. 
*/

public class Ascensor
{
    //atributos privados
    private int pisoActual, pisoMinimo, pisoMaximo;
    private float pesoMaximo;

    // Constructor
    public Ascensor(int pisoActual, int pisoMaximo, int pisoMinimo, float pesoMaximo)
    {
        this.pisoActual = pisoActual;
        this.pisoMaximo = pisoMaximo;
        this.pisoMinimo = pisoMinimo;
        this.pesoMaximo = pesoMaximo;
    }

    //metodo con los estados del ascensor, subir , bajar , sobrecara, alarma
    public void setPiso(int pisoDestino, float pesoActual)
    {

        if (pisoDestino == pisoActual)  // inmovil
        {
            Console.WriteLine("El piso destino es el actual.");
        }
        else // antes de moverse debe combrobar si el peso es el adecuado
        {
            if (pesoActual > pesoMaximo || pisoDestino < pisoMinimo || pisoDestino > pisoMaximo)
            {
                alarma();
                if (pesoActual > pesoMaximo)
                    Console.WriteLine("Peso maximo excedido");
                if (pisoDestino < pisoMinimo)
                    Console.WriteLine("Piso destino por debajo del numero de pisos");
                if (pisoDestino > pisoMaximo)
                    Console.WriteLine("Piso destino excede el numero de pisos");


            }
            else
            {  // el ascensor puede subir y bajar
                if (pisoDestino > pisoActual) {  // subir
                    Console.WriteLine("Subiendo al piso " + pisoDestino + "...");
                pisoActual = pisoDestino;
                 
                }else    // bajar
                    Console.WriteLine("Bajando al piso " + pisoDestino + "...");
                pisoActual = pisoDestino;


            }

        }
    }

   //Metodo alarma --> si se sobrepasa el peso
   private void alarma()
    {
        Console.WriteLine("Beep beep beep");
    }



}


public class Program
{
    static void Main(string[] args)
    {
        Ascensor A1 = new Ascensor(1,6, 1, 750f);
        A1.setPiso(3,300f);
        Console.WriteLine();
        A1.setPiso(5, 800f);
        Console.WriteLine();
        A1.setPiso(7, 300f);
    }
}
