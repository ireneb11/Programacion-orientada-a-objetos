/*
 EJERCICIO 5
Realizar un programa que se le pase un conjunto, un array de 10 vectores 
tridimensionales y lo guarde en un archivo txt, en el que, en cada línea del 
archivo, se guarde un vector. Hay que recordar que estamos hablando de 
vectores tridimensionales constituidos por tres float.

1º crear, abrir, rellenar y cerrar el archivo.
    
2º abrir el archivo, leerlo y mostrar su contenido por pantalla.



 */

using System;
using System.IO;
using System.Numerics;

class Program {
    static void Main(string[] args) {

        // Crear un array de 10 vectores tridimensionales
        Vector3[] vectores = new Vector3[10];

        Random rand = new Random();
        for (int i = 0; i < vectores.Length; i++) {
            float x = (float)(rand.NextDouble() * 10);  // Generamos un valor float aleatorio entre 0 y 10
            float y = (float)(rand.NextDouble() * 10);
            float z = (float)(rand.NextDouble() * 10);
            vectores[i] = new Vector3(x, y, z);  // Creamos el vector con los valores generados
        }


        // Definir la ruta del archivo
        string filePath = "vectores.txt";

        int tabla = vectores.Length;

        // Crear y rellenar el archivo con 10 vectores tridimensionales
        using (StreamWriter sw = new StreamWriter(filePath)) {
            for (int i = 0; i > tabla; i++) { 
                sw.WriteLine($"Vector {i}: {arrayVectores[i].getx()}")
                sw.
            }
        
        
        }




    }


}
