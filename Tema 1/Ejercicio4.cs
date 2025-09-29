using System;

class Empleado{
  // atributos
  public int ID {get; private set};
  private float salario;
  private int numeroHorasMax;

  // Constructor
  public Empleados(int ID, float salario, int numeroHorasMax){
    this.ID = ID;
    this.salario = salario;
    this.numeroHorasMax = numeroHorasMax;
  }

  

  
}



public class Program{
  static void Main(string[]arg){
    
    Empleado.E1= new Empleado(45, 356.7f,30);
    Console.WriteLine (P1.ID);
    
  }
}
