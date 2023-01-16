using System;  
using System.Collections.Generic;  
using System.Linq;

class Program {
  public static void Main() {
    var fs = new List<Fabricante> {
      new Fabricante { Id = 1, Descricao = "Honda" },
      new Fabricante { Id = 2, Descricao = "VW" },
      new Fabricante { Id = 3, Descricao = "Fiat" },
      new Fabricante { Id = 4, Descricao = "GM" }
    };
    var vs = new List<Veiculo> {
      new Veiculo { Id = 1, Modelo = "Punto", Ano = 2010,
        Preco = 55000, IdFabr = 3 },
      new Veiculo { Id = 2, Modelo = "Gol", Ano = 2015,
        Preco = 40000, IdFabr = 2 },
      new Veiculo { Id = 3, Modelo = "Corsa", Ano = 2015,
        Preco = 38000, IdFabr = 4 },
      new Veiculo { Id = 4, Modelo = "Civic", Ano = 2019,
        Preco = 100000, IdFabr = 1 }
    };
    
    //List<string> ls = new List<string>();
    //foreach(Fabricante f in fs)
    //  ls.Add(f.Descricao);

    var ls = fs.Select(x => x.Descricao);
    // select Descricao from fs
    var ls2 = from x in fs select x.Descricao;
    foreach(string s in ls) Console.WriteLine(s);
    foreach(string s in ls2) Console.WriteLine(s);

    // select * from vs 
    // where Preco < 50000
    var listav = vs.Where(v => v.Preco < 50000);
    var listav2 = from v in vs where v.Preco < 50000 select v;
    foreach(Veiculo v in listav) 
      Console.WriteLine(v.Modelo + " " + v.Ano + " " + v.Preco);
    foreach(Veiculo v in listav2) 
      Console.WriteLine(v.Modelo + " " + v.Ano + " " + v.Preco);
  }
} 


class Fabricante {
  public int Id { get; set; }
  public string Descricao { get; set; }
}

class Veiculo {
  public int Id { get; set; }
  public string Modelo { get; set; }
  public int Ano { get; set; }
  public double Preco { get; set; }
  public int IdFabr { get; set; }
}