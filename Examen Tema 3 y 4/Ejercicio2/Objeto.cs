public class Objeto{
  // atributos
  public string nombre {get; set;}
  public string categoria {get; set;}
  public int rareza {get; set;}

  public Objeto(string nombre,string categoria, int rareza ){
    this.nombre = nombre;
    this.categoria = categoria;
    this.rareza = rareza;
    
  }
}
