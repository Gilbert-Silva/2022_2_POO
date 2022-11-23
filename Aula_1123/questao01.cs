using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe os dados do 1º país");
    Pais m = new Pais( // 2.5
      Console.ReadLine(), int.Parse(Console.ReadLine()),
      double.Parse(Console.ReadLine()));
    for (int i = 2; i <= 10; i++) {  //2.5
      Console.WriteLine($"Informe os dados do {i}º país");
      Pais x = new Pais(
        Console.ReadLine(), int.Parse(Console.ReadLine()),
        double.Parse(Console.ReadLine()));
      if (x.Densidade() > m.Densidade()) m = x;  //2.5
    }
    Console.WriteLine(m);
  }
}

class Pais {                           //2.5
  private string nome = "Sem nome";    //2.5
  private int populacao = 1;
  private double area = 1;
  public Pais(string n, int p, double a) { //2.5
    if (n != "") nome = n;
    if (p > 0) populacao = p;
    if (a > 0) area = a;
  }
  public void SetNome(string nome) {  //2.5
    if (nome != "") this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0) 
      this.populacao = populacao;
  }  
  public void SetArea(double area) {
    if (area > 0) this.area = area;
  }  
  public string GetNome() { //2.5
    return nome;
  }
  public int GetPopulacao() {
    return populacao;
  }
  public double GetArea() {
    return area;
  }
  public double Densidade() { //2.5
    return populacao/area;
  }
  public override string ToString() { //2.5
    return $"{nome} - {populacao} - {area}";
  }
}