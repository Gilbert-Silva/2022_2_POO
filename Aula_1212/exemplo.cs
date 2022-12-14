using System;
using System.Collections;

class Program {
  public static void Main() {
    Equipe eq = new Equipe("Brasil");
    eq.Inserir(new Jogador("C", 1, 5));
    eq.Inserir(new Jogador("A", 6, 3));
    eq.Inserir(new Jogador("E", 2, 2));
    eq.Inserir(new Jogador("B", 11, 1));
    eq.Inserir(new Jogador("D", 4, 0));
    Console.WriteLine("Listagem em ordem alfabética");
    foreach(Jogador j in eq.Listar())
      Console.WriteLine(j);
    Console.WriteLine("Listagem em ordem da camisa");
    foreach(Jogador j in eq.Camisas())
      Console.WriteLine(j);
    Console.WriteLine("Listagem em ordem de gols");
    foreach(Jogador j in eq.Artilheiro())
      Console.WriteLine(j);
  }
}
                             // Generic
class Jogador : IComparable, IComparable<Jogador> {  // 5
  private string nome;  // 5
  private int camisa, numGols;
  public Jogador(string n, int c, int g) { // 5
    nome = n;
    camisa = c;
    numGols = g;
  }
  public string Nome { // 5
    get { return nome; }
    set { nome = value; }
  }
  public int Camisa {
    get { return camisa; }
    set { camisa = value; }
  }
  public int NumGols {
    get { return numGols; }
    set { numGols = value; }
  }
  public override string ToString() { // 5
    return $"{nome} {camisa} {numGols}";
  }
  public int CompareTo(object obj) { // 5
    Jogador j1 = this;
    Jogador j2 = (Jogador) obj;
    return j1.nome.CompareTo(j2.nome);
  }  
  // Generic
  public int CompareTo(Jogador obj) {
    return this.nome.CompareTo(obj.nome);
  }  
}

class Equipe {
  private string pais; // 5
  private Jogador[] jogs = new Jogador[25];
  private int k;
  // private List<Jogador> jogs = new List<Jogador>();
  // private List<object> jogs = new List<object>();
  // private ArrayList jogs = new ArrayList();
  // is
  public void Inserir(Jogador j) { // 5
    if (k < 25)
      jogs[k++] = j;
  }  
  public Jogador[] Listar() { // 5
    Jogador[] temp = new Jogador[k];
    Array.Copy(jogs, temp, k);
    Array.Sort(temp);
    return temp;
  }
  public Jogador[] Artilheiro() { // 5
    int n = 3;
    if (k < 3) n = k;
    Jogador[] temp = new Jogador[n];
    Array.Copy(jogs, temp, n);
    Array.Sort(temp, new CompararGols());
    return temp;
  }
  public Jogador[] Camisas() { // 5
    Jogador[] temp = new Jogador[k];
    Array.Copy(jogs, temp, k);
    Array.Sort(temp, new CompararCamisa());
    return temp;
  }
  public Equipe(string p) { // 5
    pais = p;
  }
  public override string ToString() { 
    return $"{pais} - {k} jogador(es)";
  }
}

class CompararGols : IComparer { // 10
  public int Compare(object obj1, object obj2) { 
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return -j1.NumGols.CompareTo(j2.NumGols);
  }  
}

class CompararCamisa : IComparer { // 10
  public int Compare(object obj1, object obj2) { 
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return j1.Camisa.CompareTo(j2.Camisa);
  }  
}
