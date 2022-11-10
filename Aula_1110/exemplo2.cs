using System;
using System.Collections;

class Program {
  public static void Main() {
    ArrayList lista = new ArrayList(); // lista = []
    lista.Add("TADS");                 // lista.append("TADS")
    lista.Add(2002);
    lista.Add("Redes");
    lista.Add(2008);
    Console.WriteLine(lista[0]);       // print (lista[0])
    Console.WriteLine(lista[1]);       
    Console.WriteLine(lista[0].GetType());       
    Console.WriteLine(lista[1].GetType());
    Console.WriteLine((int)lista[1] + (int)lista[3]);
    Console.WriteLine(((string)lista[0])[0]);       
  }
}