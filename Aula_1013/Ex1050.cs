using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();
    if (s == "61") Console.WriteLine("Brasilia");
    else if (s == "71") Console.WriteLine("Salvador");
    else if (s == "11") Console.WriteLine("Sao Paulo");
    else if (s == "21") Console.WriteLine("Rio de Janeiro");
    else if (s == "32") Console.WriteLine("Juiz de Fora");
    else if (s == "19") Console.WriteLine("Campinas");
    else if (s == "27") Console.WriteLine("Vitoria");
    else if (s == "31") Console.WriteLine("Belo Horizonte");
    else Console.WriteLine("DDD nao cadastrado");
  }
  public static void Main2() {
    string s = Console.ReadLine();
    switch(s) {
      case "61": Console.WriteLine("Brasilia"); break; 
      case "71": Console.WriteLine("Salvador"); break;
      case "12":
      case "11": Console.WriteLine("Sao Paulo"); break;
      case "21": Console.WriteLine("Rio de Janeiro"); break;
      case "32": Console.WriteLine("Juiz de Fora"); break;
      case "19": Console.WriteLine("Campinas"); break;
      case "27": Console.WriteLine("Vitoria"); break;
      case "31": Console.WriteLine("Belo Horizonte"); break;
      default  : Console.WriteLine("DDD nao cadastrado"); break;
    }
  }
}

/*
    if (s == "61") Console.WriteLine("Brasilia");
    else 
      if (s == "71") Console.WriteLine("Salvador");
      else 
        if (s == "11") Console.WriteLine("Sao Paulo");
        else 
          if (s == "21") Console.WriteLine("Rio de Janeiro");
          else 
            if (s == "32") Console.WriteLine("Juiz de Fora");
            else 
              if (s == "19") Console.WriteLine("Campinas");
              else 
                if (s == "27") Console.WriteLine("Vitoria");
                else 
                  if (s == "31") Console.WriteLine("Belo Horizonte");
                  else Console.WriteLine("DDD nao cadastrado");
*/
