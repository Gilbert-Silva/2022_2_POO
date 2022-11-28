using System;
using System.Collections;

class Program {
  public static void Main() {
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    IEnumerator it = v.GetEnumerator();
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    Stack pilha = new Stack();
    pilha.Push("Tecnologia");
    pilha.Push("Análise");
    pilha.Push("Desenvolvimento");
    pilha.Push("Sistemas");
    IEnumerator it2 = pilha.GetEnumerator();  
    it2.MoveNext();
    Console.WriteLine(it2.Current);
    it2.MoveNext();
    Console.WriteLine(it2.Current);
    

    
    
    //Console.WriteLine(pilha[0]);
    Console.WriteLine(pilha.Pop());
    Console.WriteLine(pilha.Pop());
    Console.WriteLine(pilha.Pop());
    Console.WriteLine(pilha.Pop());
    
    
  }
}