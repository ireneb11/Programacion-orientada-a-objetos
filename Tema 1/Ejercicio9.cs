using System;

public class Personaje{
// atributos de todos los personajes
  private string nombre {get;set};
  private int nivel, puntosDeVida;

// constructor
public Personaje (string nombre, int nivel, int puntosDeVida){
  this.nombre=nombre;
  this.nivel=nivel;
  this.puntosDeVida=puntosDeVida;
}

public virtual mostrarInfo(){
  getNombre();
  
  
}

public class Guerrero: Personaje{
  private float fuerza;

  // Constructor
  public Guerrero (string nombre, int nivel, int puntosDeVida, float fuerza): base (nombre, nivel, puntosDeVida){
    this.fuerza= fuerza;

  public void atacar()
  {
    Console.WriteLine($"{nombre} ataca con fuerza {fuerza}.")
    
  }
  public override mostrarInfo()
  {
    base.mostrarInfo()
    Console.WriteLine
  }
  }
public class Mago: Personaje{
  private float Inteligencia;

  // Constructor
  public Mago (string nombre, int nivel, int puntosDeVida, float inteligencia): base (nombre, nivel, puntosDeVida){
    this.inteligencia= inteligencia;
  
}

  public class Sanador: Personaje{
  private float sabiduria;

  // Constructor
  public Sanador (string nombre, int nivel, int puntosDeVida, float sabiduria): base (nombre, nivel, puntosDeVida){
    this.sabiduria= sabiduria;
