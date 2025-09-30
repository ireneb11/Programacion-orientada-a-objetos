using System;

/*  EJERCICIO 4
Construir una definición de clase que se pueda utilizar para representar un 
empleado de una compañía. Cada empleado se define por un número entero ID, 
un salario y el número máximo de horas de trabajo por semana. Los servicios 
que debe proporcionar la clase, al menos deben permitir introducir datos de un 
nuevo empleado, visualizar los datos existentes de un nuevo empleado y 
capacidad para procesar las operaciones necesarias para dar de alta y de baja 
en la seguridad social y en los seguros que tenga contratados la compañía. 
 
 
 */


class Empleado
{
    // atributos
    private int ID;
    private float salario;
    private int numeroHorasMax;
    private bool estadoDadoAlta;
    private int seguridadSocial;

    // Constructor
    public Empleado()
    {
        // inicializamos valores por defecto
        ID = 0;
        salario = 0f;
        numeroHorasMax = 0;
        estadoDadoAlta = false;
    }

    // metodo para introducir datos
    public void IntroducirDatos(int ID, float salario, int numeroHorasMax)
    {
        this.ID = ID;
        this.salario = salario;
        this.numeroHorasMax = numeroHorasMax;
    }

    public void VisualizarDatos()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Salario: {salario}");
        Console.WriteLine($"Max Horas Semana: {numeroHorasMax}");
        Console.Write("Estado alta: ");
        if (estadoDadoAlta)
        {
            Console.WriteLine("Dado de Alta");
        }
        else
        {
            Console.WriteLine("Dado de Baja");
        }
    }

    public void SeguridadSocial()
    {

        Console.WriteLine("Elija una de las siguientes opciones \n 1: Dar de alta \n 2: Dar de Baja");
        seguridadSocial = Convert.ToInt32(Console.ReadLine());
        while (seguridadSocial != 1 && seguridadSocial != 2) 
        {
            Console.Write("Por favor escriba solo una de las dos opciones: ");
            seguridadSocial = Convert.ToInt32(Console.ReadLine());
        }

        switch (seguridadSocial)
        {
            case 1: // Dar de alta
                estadoDadoAlta = true;
                Console.WriteLine("Empleado dado de alta en la seguridad social y seguros.");
                break;
            case 2:   // dar de baja
                estadoDadoAlta = false;
                Console.WriteLine("Empleado dado de alta en la seguridad social y seguros.");
                break;
        }
    }


    public class Program
    {
        static void Main(string[] arg)
        {

            Empleado E1 = new Empleado();
            E1.IntroducirDatos(12345, 1500.50f, 40);
            E1.VisualizarDatos();
            E1.SeguridadSocial();
            E1.VisualizarDatos();

        }
    }
}
