/*
EJERCICIO 7
Implementar el método guardarListado. El método guarda un array de nombres
en un archivo. Si el archivo no existe, el método lo crea. Si el archivo existe,
borra su contenido y escribe en él. Por último, el método inserta cada nombre
del array en una fila diferente dentro del archivo. Por ejemplo, si el array contiene
los nombres “María José” y “Ana”, en el archivo debe aparecer:
María José
Ana
El método devuelve 0 si no se ha guardado correctamente en el archivo o ha
habido un error, y 1 si se ha creado correctamente y se han guardado los datos. 
*/


using System;
using

class Program{
  static void Main(string[]arg){

    // guardamos los nombres en un array
    string[] nombres = { "María José", "Ana", "Luis", "Carlos" };

    string filePath = "nombres.txt";

    int resultado = guardarListado(nombres, filePath);

  // explica si se ha podido escribir en el archivo o no.
  if (resultado == 1)
      Console.WriteLine("Listado guardado correctamente.");
  else
      Console.WriteLine("Error al guardar el listado.");


    

 

    public static int GuardarArray(string [] lista, string rutaDelArchivo){
      // verifica si el archivo existe y si es asi lo elimina
      if (File.Exists(filePath)){
        File.Delete(filePath)
      }
      // crea el archivo
      using FileStream fs = File.Create(filePath){
  
        try{
          using (StramWriter writer = new StreamWriter(filePath)){  // escribe en el archivo abriendo un straem y el using se encarga de cerrarlo
            foreach (string nombre in nombres)
            {
                writer.WriteLine(nombre);
            }
          }
          return 1;
        }
        catch (Exception ex){
            // Si hay un error, mostramos un mensaje y devolvemos 0
            Console.WriteLine("Error al guardar el listado: " + ex.Message);
            return 0;
        }
      }
    }
    
}


