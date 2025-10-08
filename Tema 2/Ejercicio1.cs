namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir el nombre
            Console.WriteLine("Introduce tu nombre: ");
            string ? nombre = Console.ReadLine();

            // Pedir el año de nacimiento
            Console.WriteLine("Introduce tu año de nacimiento: ");
            int anioNacimiento = Convert.ToInt32(Console.ReadLine()); // Convertir la entrada a entero -> Tambien se puede usar int.Parse(). // o (int)(Console.ReadLine()

            // Pedir el año actual
            Console.WriteLine("Introduce el año actual: ");
            int anioActual = int.Parse(Console.ReadLine()); 


            while (anioNacimiento > anioActual) { 
                Console.WriteLine("Error en el año de nacimiento o eres un viajero del tiempo.");

                Console.WriteLine("Introduce tu año de nacimiento: ");
                anioNacimiento = Convert.ToInt32(Console.ReadLine());

            } 

          // Calculamos la edad actual usando el metodo
          int edadActual = CalcularEdad  (anioActual, anioNacimiento)

            //Calculamos la edad que tendrá en el año 2030
            int edadEn2030 = CalcularEdad(2030, anioNacimiento )

          Console.WriteLine("Hola " + nombre);



          // Metodo que recibe el año actual y el año de nacimiento y devuelve la edad actual
          static int CalcularEdad (int anioActual, int anioNacimiento){  // si no pongo nada es publico
              return anioActual - anioNacimiento;
          }
        }
    }
}
