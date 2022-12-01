using System;

class Program {
  public static void Ordenar(object[] v) {
    if (((IComparable)v[0]).CompareTo(v[1]) == 1) {
      object aux = v[0];
      v[0] = v[1];
      v[1] = aux;
    }
    if (((IComparable)v[0]).CompareTo(v[2]) == 1) {
      object aux = v[0];
      v[0] = v[2];
      v[2] = aux;
    }
    if (((IComparable)v[1]).CompareTo(v[2]) == 1) {
      object aux = v[1];
      v[1] = v[2];
      v[2] = aux;
    }
  }
  
  public static void Main() {
    Jogador j1 = new Jogador { Nome = "Felipe", Altura = 180 };
    Jogador j2 = new Jogador { Nome = "Andre", Altura = 182 };
    Jogador j3 = new Jogador { Nome = "Radmila", Altura = 170 };
    Jogador[] js = { j1, j2, j3 };
    Array.Sort(js);
    //Ordenar(js);
    foreach(Jogador j in js)
      Console.WriteLine(j);

    Console.WriteLine(j1.CompareTo(j1));
    Console.WriteLine(j1.CompareTo(j2));
    Console.WriteLine(j1.CompareTo(j3));
    /*
    int x = 5;
    int y = 3;
    int z = 8;
    Console.WriteLine(x.CompareTo(x));
    Console.WriteLine(x.CompareTo(y));
    Console.WriteLine(x.CompareTo(z));
    */
  }  
}

// https://learn.microsoft.com/pt-br/dotnet/api/system.icomparable?view=net-7.0

//interface IComparable {
//  int CompareTo(object obj);
//}

class Jogador : IComparable {
  public string Nome {get; set;}
  public int Altura {get; set;}
  public int CompareTo(object obj) {
    // this - j1
    // obj  - j2  obj.Nome, obj.Altura
    Jogador r = (Jogador) obj;
    return this.Altura.CompareTo(r.Altura);
    //if (this.Nome.CompareTo(r.Nome) == -1) return -1;
    //if (this.Nome.CompareTo(r.Nome) == 1) return 1;
    //return 0;
  }
  public override string ToString() {
    return $"{Nome} - {Altura}";
  }
}