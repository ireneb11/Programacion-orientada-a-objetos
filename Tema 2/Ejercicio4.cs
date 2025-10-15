/*
EJERCICIO 4
Crear una clase llamada Vector3 que cree vectores tridimensionales. Debe tener, 
al menos, dos constructores uno por defecto que cree un vector de coordenadas 
0.0f,0.0f,0.0f y otro en el que se le pasen las coordenadas x,y,z y entonces cree 
el vector. Implementar todos los métodos consultores y modificadores. También 
añadir un método que nos calcule y devuelva el módulo del vector, así como otro 
método que normalice el vector.
 */

using System;



class Vector3 { 
    // variables
    private float x;
    private float y;
    private float z;


    // Constructor por defecto
    public Vector3() { 
        x = 0.0f;
        y = 0.0f;
        z = 0.0f;

    }

    // Constructor con parámetros
    public Vector3(float x, float y, float z) { 
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Métodos consultores
    public float GetX() {  return x; }

    public float GetY() {  return y; }
    public float GetZ() {  return z;}

    // Métodos modificadores
    public void SetX(float x) { 
        this.x = x;
    }
    public void SetY(float y) { 
        this.y = y;
    }
    public void SetZ(float z) { 
        this.z = z;
    }

    // Método que calcula el módulo del vector
    public float GetModulo() { 
        float modulo = (float)Math.Sqrt(x * x + y * y + z * z);   // (float) para convertir el resultado de Math.Sqrt (double) a float
        return modulo;

        
    }

    // Método que normaliza el vector
    public void Normalizar() { 
        float modulo = GetModulo();
        if (modulo > 0.0f) { // evitamos division por 0
            x /= modulo;
            y /= modulo;
            z /= modulo;
        }
    }

    


}


class Program { 
    static void Main(string[] args) { 
        Vector3 v1 = new Vector3();
        Vector3 v2 = new Vector3(1.0f, 2.0f, 3.0f);
    }



}
