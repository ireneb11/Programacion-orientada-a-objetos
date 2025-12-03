public class Inventario{
  // -------------------1. OREDENAR RAREZAS -----------------
  // bubble sort
  public static void OrdenarRarezasBubbleSort(List<Objeto> inventario){
    if (inventario ==null || inventario.Count<2){ return;}

    for (int i = 0; i< inventario.Count-1;i++){
      for (int j=0; j<inventario.Count-i-1; j++){
        if (inventario[j].rareza > inventario[j+1].rareza){
          Objeto temp = inventario[j];
          inventario[j] = inventario[j+1];
          inventario[j+1] = temp;
        }
      }
    }
  }

  // inserccion
  public static void OrdenarRarezasInserccion(List<Objeto> inventario){
    if (inventario ==null || inventario.Count<2){ return;}
    for (int i = 0; i< inventario.Count-1;i++){
      
      int j=i-1;
      Objeto act = inventario[i];
      while(j>=0 && inventario[j].rareza > act.rareza){
        inventario[j+1] =inventario[j]
        j--;
      }
      inventario[j+1] = act;
    }
  }



  //   ----2. Búsqueda Multicriterio--------
  public static List<Objeto> BusquedaMultiCriterio (List<Objeto> inventario, string fragmento, int rarezaMin, string mismaCantegoria){
    
    List<Objeto> ObjetosConCriterio = new List<Objeto>();
    if (inventario ==null || inventario.Count=0){ return ObjetosConCriterio;}

    foreach (Objeto obj in inventario){
      // 1 comparar nombre
      bool oknombre= false;
      if (obj.nombre ==null){obj.nombre ="";}
      if (fragmento != null || fragmento != ""){
        oknombre= obj.nombre.ToLower().Contains(fragmento.ToLower());
      }
      else{
        oknombre= true; //si frag es ulo contamos como que le vale cualquier objeto e  ese criterio
      }

      // 2. rareza
      bool okrareza = (obj.rareza >= rarezaMin);

      //3. = caracteristica
      bool okcatego= false;
      if (obj.carategoria ==null){obj.carategoria ="";}
      if (mismaCantegoria != null || mismaCantegoria != ""){
        okcatego= obj.carategoria.ToLower().Equals(mismaCantegoria.ToLower());
      }
      else{
        okcaract= true; //si frag es ulo contamos como que le vale cualquier objeto e  ese criterio
      }


      if (oknombre && okrareza && okcaract){
        ObjetosConCriterio.Add(obj);
      }
    }

    return ObjetosConCriterio;
  }


  // 3. Búsqueda por Categoría Específica -binario
  // antes hay que ordenar el inventario por categorias
  public static void OrdenarPorCategoriasInsercion (List<Objeto> inventario){
    if (inventario ==null || inventario.Count=0){ return;}

    for(int i =0;i< inventario.Count -1;i++){
      Objeto actual = inventario[i]
      int j=i-1;
      int comp = inventario[j].categoria.ToLower(9.CompareTo(actual.categoria.ToLOwer())
      while(j<=0 && comp>0){
        inventario[j+1] = inventario[j];
        j--;
      }
      inventario[j+1]= actual;                                     
    }
  }

                                                 
  public static List<Objeto> BusquedaCategoriaBinario (List<Objeto> inventarioOrdenado, string categoriaBUsc){
    // inventario ordenado
    List<Objeto> ObjetosCategoria = new List<Objeto>();
    if (inventarioOrdenado ==null || inventarioOrdenadoCount=0){ return ObjetosCategoria;}
    

    // 1) encuentra pos categoria
    int inicio = 0;
    int final = inventarioOrdenado.Count -1;
    int posEsperada = -1;
    while (inicio< final){
      int medio =(inicio + final)/2;
      int comp= inventarioOrdenado[medio].categoria.ToLower().CompareTo(categoriaBUsc.ToLower())
      if (comp== 0){
        posEsperada = medio;
        break;
      }
      else if(comp>0){
        final = medio-1;  
      }
      else{
        inicio = medio +1;
      }
    }
    // 2) expandir izaq
    int i = posEsperada;
    while(i>=0 && inventarioOrdenado[i].categoria.ToLower().Equals(categoriaBUsc.ToLower())){
      i--;
    }
    int inicioCat = i+1;

    // 3) expandir derech
    i = posEsperada;
    while(i<inventarioOrdenado.Count && inventarioOrdenado[i].categoria.ToLower().Equals(categoriaBUsc.ToLower())){
      i++;
    }
    int finalCat = i;

    //4) añadir lista
    for(int k = inicioCat, k< finalCat; k++){
      ObjetosCategoria.Add(inventarioOrdenado[k])
    }
        
    return ObjetosCategoria;
  }
                                                 
  // 4. Optimización con Búsqueda Binaria
  public static List<Objeto> BusquedaMultiCriterio (List<Objeto> inventarioOrdenadoCateg, Objeto categoriaBUsc){
    if (inventarioOrdenado ==null || inventarioOrdenadoCount=0){ return new List<Objeto>();}

    return BusquedaCategoriaBinario (inventarioOrdenadoCateg, categoriaBUsc.categoria)
  }    



  //5. Estadísticas del Inventario
  public static void CalcularEstadisticas (List<Objeto> inventario, out int cantidad,out int rarezaTotal, out double rarezaProm ){  
    cantidad = 0;
    rarezaTotal=0;
    rarezaProm=0.0;
    if (inventario ==null || inventario.Count<2){ return;}

    foreach (Objeto obj in inventario){
      cantidad += 1;
      rarezaTotal += obj.rareza;
    }

    if (cantidad !=0){
      double cT = (double)cantidad;
      double rT = (double)rarezaTotal;
      rarezaProm = rT/cT;
    }
  }
}                                      
