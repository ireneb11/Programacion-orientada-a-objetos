public class Principal{
  public static void Main(string[]arg){
      List<Objeto> inventario= new List<Objeto>();
      inventario.Add("Espada Maestra", "Armas",100);
      inventario.Add( "Escudo Hyliano", "Defensas", 50);

    
      Console.WriteLine("Inventario original:");
  
  
  }
  public static void ImprimirLista(List<Objeto> lista){
    if(lista== null ||lista.Count==0){return;}

    foreach (Objeto obj in lista){
      Console.WriteLine(obj.ToString());
    }
  }

  public static List<Objeto> CopiaLista(List<Objeto> lista){
    List<Objeto> copia = new List<Objeto>();
    if(lista== null ||lista.Count==0){return;}

    foreach (Objeto obj in lista){
      copia.Add(obj);
    }
  }
  
}
