public class Organizador{
  // -----------1. Pila de Objetos Valiosos (pilaValiosos): 
  public static Stack<Objeto>  ObjeterValiosos(Queue<Objeto> colaInicial, int umbral){
    if (colaInicial ==null|| colaInicial.Count==0) {
      throw new ArgumentNullException("colaInicial","La cola no puede estar vacia");
    }
    if (umbral <0){umbral=0;}
    
    Stack<Objeto> ObjetosValiosos = new  Stack<Objeto>();
    foreach(Objeto obj in colaInicial){
      if (obj== null){continue;}
      if(obj.valor >= umbral){
        ObjetosValiosos.Push(obj);
      }
    }
    return ObjetosValiosos;
    
  }

  // -----------2.Cola de Objetos Comunes (colaComunes): 
  public static Queue<Objeto>  ObjeterComunes (Queue<Objeto> colaInicial, int umbral){
    if (colaInicial ==null|| colaInicial.Count==0) {
      throw new ArgumentNullException("colaInicial","La cola no puede estar vacia");
    }
    if (umbral <0){umbral=0;}
    
    Queue<Objeto> ObjetosComunes = new  Queue<Objeto>();
    foreach(Objeto obj in colaInicial){
      if(obj == null){continue;}
      if(obj.valor < umbral){
        ObjetosComunes.Enqueue(obj);
      }
    }
    return ObjetoObjetosComunes;
    
  }


  
  // -----------3.Lista Doblemente Enlazada por Tipo de Objeto
  public static LinkedList<Objeto>  ObjeterPorTipo (Queue<Objeto> colaInicial){
    if (colaInicial ==null|| colaInicial.Count==0) {
      throw new ArgumentNullException("colaInicial","La cola no puede estar vacia");
    }

    //1 diccionario
    //2 lista simpple de un tipo
    // 3 lista doble con cada tipo

    Dictionary<string, List<Objeto>> diccionarioPorTipos = new Dictionary<string, List<Objeto>;
    foreach (Objeto obj in colaInicial){
      if (obj == null){continue;}

      
    }
  }
}
