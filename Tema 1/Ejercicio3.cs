/* EJERCICIO 3
 
 Construir una clase llamada Luz que simule un semáforo. El atributo color de la 
clase debe cambiar de Verde a Amarillo y a Rojo y de nuevo regresar a Verde 
mediante la función Cambio. Cuando un objeto Luz se crea, su color inicial será 
Rojo
 
 */

public class Luz
{
    //atributo color
    private string color { get; set; }

    //Constructor
    public Luz()
    {
        color = "Rojo";
    }

    // metodo cambio
    public void cambio()
    {
        switch (color)
        {
            case "Rojo":
                color = "Verde";
                break;
            case "Verde":
                color = "Amarillo";
                break;
            case "Amarillo":
                color = "Rojo";
                break;
        }


    }
    //metodo get
    public string getColor() {
         return color; 
    }
}

public class Program
{
    static void Main(string[] arg)
    {
        Luz semaforo = new Luz();
        
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(semaforo.getColor());
          semaforo.cambio();
    
            //pausa de 1 segundo
            System.Threading.Thread.Sleep(1000);

        }
    }
}
