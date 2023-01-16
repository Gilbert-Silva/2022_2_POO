using System; 
using System.Collections.Generic; 

class Program {
  public static void Main() {
    var i = 10;
    Console.WriteLine(i);
    Console.WriteLine(i.GetType());
    //i = "Teste";
    var v1 = new { modelo="Gol", marca="VW", ano=2010, preco=30000.0 };
    var v2 = new { modelo="Golf", marca="VW", ano=2010, preco=60000.0 };    Console.WriteLine(v1);
    Console.WriteLine(v1.GetType());
    Console.WriteLine(v1.modelo);
    Console.WriteLine(v2.GetType());
    Console.WriteLine(v2.modelo);

    List<string> l1 = new List<string> {
      "Tecnologia",
      "Análise e Desenvolvimento",
      "Sistemas"
    };   
    List<string> l2 = new List<string>();
    l2.Add("Tecnologia");
    
  }
}