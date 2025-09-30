using System;

Crear una clase llamada hora que tenga miembros datos separados de tipo int 
para horas, minutos y segundos. Un constructor inicializará este dato a 0 y otro 
lo inicializará a valores fijos. Una función miembro deberá visualizar la hora en 
formato 11:59:59. Otra función miembro sumará dos objetos de tipo hora 
pasados como argumentos. Una función principal Main() crea dos objetos 
inicializados y uno que no está inicializado. Sumar los dos valores inicializados 
y dejar el resultado en el objeto no inicializado. Por último, visualizar el valor 
resultante. 

  
public class Hora{
  // datos miembro
  private int horas, minutos, segundos;

  // constructor predeterminado y valores fijos
  public Hora(){
    horas = 0;
    minutos= 0;
    segundos= 0;
  }

  public Hora(int horas,int minutos,int segundos){
    this.horas = horas;
    this.minutos = minutos;
    this.segundos = segundos;
  }

  // metodo hora digital
  public void horaDigital(){
    Console.Writeline($"La hora es-> {horas}:{minutos}:{segundos}")
  }

  // Metodo sumar hora
  public void sumar(){
    
  }
  
}
