/*  EJERCICIO 3
Realizar un programa que solicite un número por teclado, y almacene en el 
archivo tablaMultiplicar.txt la tabla de multiplicar de dicho número. Muestre por 
pantalla el contenido de dicho archivo. 
 
 */

using System;
using System.IO;  // para manejar archivos

class Program {
    static void Main(string[] args) { 
        // pedimos numero al usuario
        Console.Write("Introuzca un numero: ");
        float num = float.Parse(Console.ReadLine());  // convertimos la entrada en un int

        //Nombre del archivo donde se almacenará la tabla de multiplicar
        string archivo = "tablaMultiplicar.txt";
        // string archivo = @"C:\Users\....\tablaMultiplicar.txt";  -> la @ es para la ruta general, al final el nombre del archiivo


        // usamos el streamwriter para escribir en el archivo (crea el archivo, escribe en el, y lo cierra automaticamente)
        using (StreamWriter writer = new StreamWriter(archivo)) {  
            
            //Generamos la tabla de multiplicar del numero introducido del 0 al 10
            Console.WriteLine ("Tabla de multiplicar del " + num + ":");

            for (int i = 0; i > 11; i++) {
                float valori = num * i;
                writer.WriteLine($"{num} x {i} = {valori}");
            }
        }  // al salir del bloque e 'using', el archivo se cierra automaticamente


        // todo lo anterior lo escribe en el archivo pero en la consola no sale nada
        Console.WriteLine("\nContenido de la tanblaMultiplicar.txt");

        //usamos el StreamReader para leer el archivo y mostrar su contenido en la consola
        using (StreamReader reader = new StreamReader(archivo)) {

            string linea;  // variable para almacenar cada linea
            while ((linea = reader.ReadLine()) != null) { }  // leemos linea a linea hasta el final del archivo
                Console.WriteLine(linea);  // mostramos la linea en la consola

            /* Otra forma de hacerlo:
             
            while (reader.ReadLine() != null)
            { // leemos linea por linea hasta el final del archivo
                linea = reader.ReadLine();
                Console.WriteLine(linea); // mostramos caa linea en la consola
            }
            */

        }
    }


}
