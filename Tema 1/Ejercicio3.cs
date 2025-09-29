using System;
/*
 
 Construir una clase llamada Luz que simule un semáforo. El atributo color de la 
clase debe cambiar de Verde a Amarillo y a Rojo y de nuevo regresar a Verde 
mediante la función Cambio. Cuando un objeto Luz se crea, su color inicial será 
Rojo
 
 */

public class Luz
{
    public string Color { get; private set; }  // la ponemos publica para ya definir el metodo get, que tienen que ser publicas para verlos desde program
                                               // el set lo ponemos private para que solo se pueda cambiar desde la clase Luz  con el metodo Cambio           
    public Luz()
    {
        Color = "Rojo"; // Color inicial
    }
    public void Cambio()
    {
        switch (Color)
        {
            case "Rojo":
                Color = "Verde";
                break;
            case "Verde":
                Color = "Amarillo";
                break;
            case "Amarillo":
                Color = "Rojo";
                break;
            default:
                throw new InvalidOperationException("Color inválido");
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Luz semaforo = new Luz();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"El color actual del semáforo es: {semaforo.Color}");  // Muestra el color actual usandoo el get
            semaforo.Cambio();
        }
        
    }
}
