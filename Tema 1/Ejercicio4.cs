using System;

class Empleado{
  // atributos
  public int ID {get; private set};
  private float salario;
  private int numeroHorasMax;
  private bool estadoDadoAlta;

  // Constructor
  public Empleados(){
    // inicializamos valores por defecto
    ID = 0;
    salario = 0f;
    numeroHorasMax = 0;
    estadoDadoAlta = false;
  }
  
  // metodo para introducir datos
  public void IntroducirDatos(int ID, float salario, int numeroHorasMax){
    this.ID = ID;
    this.salario = salario;
    this.numeroHorasMax = numeroHorasMax;
  }

  public void VisualizarDatos(){
    Console.WriteLine($"ID: {Id}");
    Console.WriteLine($"Salario: {Salario}");
    Console.WriteLine($"Max Horas Semana: {MaxHorasSemana}");
    Console.WriteLine("Estado alta: ");
    if (estadoDadoAlta){
      Console.Write("Dado de Alta");
    }else{
      Console.Write("Dado de Baja");
    }
    
  }

  public void DarDeAlta(){
    Console.WriteLine("Elija una de las siguientes opciones \n 1: Dar de alta \n 2: Dar de Baja");
    Console.ReadLine
    estadoDadoAlta = true
    Console.WriteLine("Empleado dado de alta en la seguridad social y seguros.");
  }

  
  

  

  

  
}



public class Program{
  static void Main(string[]arg){
    
    Empleado.E1= new Empleado(45, 356.7f,30);
    Console.WriteLine (P1.ID);
    
  }
}
