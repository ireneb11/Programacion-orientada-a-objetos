using System;

public class Personaje{
// atributos de todos los personajes
  private string nombre;
  private int nivel, puntosDeVida;

// constructor
public Personaje (string nombre, int nivel, int puntosDeVida){
  this.nombre=nombre;
  this.nivel=nivel;
  this.puntosDeVida=puntosDeVida;
}
  
}

public class Guerrero: Personaje{
  private float fuerza;

  // Constructor
  public Guerrero (string nombre, int nivel, int puntosDeVida, float fuerza): base (nombre, nivel, puntosDeVida){
    this.fuerza= fuerza;
  
}
