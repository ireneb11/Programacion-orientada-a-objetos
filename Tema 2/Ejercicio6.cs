/* EJERCICIO 6
Crear un programa que lea archivos txt y lo muestre por pantalla, es decir, lo 
saque por la consola. El mismo programa debe guardar ese archivo txt, en 
formato binario.


NO TERMINADO !!!!!!!!



 */


using System;
using System.IO;

class Program { 
    static void Main(string[] args) {


        // especificar la ruta del archivo txt

        string rutaTxt = "archivo.txt";  // asegurate de que este archivo exista

        string rutaBin = "archivo.bin"; // Ruta del archivo binario

        // try catch par comprobar que el archivo existe  -> maxima noota
        try {
            if (!File.Exists(rutaTxt)) {
                throw new FileNotFoundException("El archivo no existe.");
            }
        } catch (FileNotFoundException e) {
            Console.WriteLine(e.Message);
            return;
        }

        // otra forma de comprobar que el archivo existe -> nota aceptable
       /*
        if (!File.Exists(rutaTxt)) {
            Console.WriteLine("El archivo no existe.");
            return;
        }
        */
