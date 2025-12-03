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
    //2
    foreach (Objeto obj in colaInicial){
      if (obj == null){continue;}

      string tipo = obj.tipo.ToLower();
      if (tipo == null){
        tipo ="";
      }
      if (!diccionarioPorTipos.ContainsKey(tipo)){
        diccionarioPorTipos[tipo] = new List<Objeto
      }
      diccionarioPorTipos[tipo].Add(obj);
    }

    //3
    LinkedList<Objeto> ObjetosPorTipo = new LinkedList<Objeto>();
    foreach(KeyValuePair pareja in diccionarioPorTipos){
      List<Objeto> list = pareja.Value;
      foreach(Objeto obj in list){
        ObjetosPorTipo.AddLast(obj)
      }
    }
    return ObjetosPorTipo;
    
  }
  // 4. Pila de Objetos Únicos 
  public static Stack<Objeto>  ObjeterUnicos(Queue<Objeto> colaInicial){
    if (colaInicial ==null|| colaInicial.Count==0) {
      throw new ArgumentNullException("colaInicial","La cola no puede estar vacia");
    }
    //1 diccionario   - nombre, veces
    //2 lista simpple de un tipo
    Dictionary<string, int> diccionarioUnicos = new Dictionary<string, int>();
    foreach (Objeto obj in colaInicial){
      if (obj == null){continue;}

      
      string nombre = obj.nombre;
      if (nombre == null){nombre="";}
      if (!diccionarioUnicos.ContainsKey(nombre)){
        diccionarioUnicos[key] = 0;
      }
      diccionarioUnicos[key] += 1;
    }

    //3 lista con los unicos
    Stack<Objeto> ObjetosUnicos = new  Stack<Objeto>();

    foreach(Object obj in colaInicial){
      int veces;
      if (obj.nombre == null){obj.nombre="";}
      bool existe = diccionarioUnicos.TryGetKey(obj.nombre, out veces);
      if (existe && veces==1){
        ObjetosUnicos.Push(obj)
      }

      return ObjetosUnicos;
    }

    

  
    
    
    
  }
  

  
}
