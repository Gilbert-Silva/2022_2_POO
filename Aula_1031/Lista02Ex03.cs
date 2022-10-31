using System;

class Program { 
  public static void Main() {
    Viagem v1 = new Viagem();
    v1.SetDistancia(350);
    v1.SetTempo(4);
    Console.WriteLine($"{v1.VelocidadeMedia()} km/h");
    Console.WriteLine(v1.ToString());
    Viagem v2 = new Viagem();
    v2.SetDistancia(80);
    v2.SetTempo(1.5);
    Console.WriteLine($"{v2.VelocidadeMedia()} km/h");
    Console.WriteLine(v2.ToString());
    Viagem v3 = new Viagem(400, 6);
    Console.WriteLine($"{v3.VelocidadeMedia()} km/h");
    v3.SetDistancia(380);
    v3.SetTempo(5.5);
    Console.WriteLine($"{v3.VelocidadeMedia()} km/h");
    Console.WriteLine(v3.ToString());
    Console.WriteLine(v3);
  }
}

class Viagem {
  private double distancia;
  private double tempo = 1;
  public Viagem() { }
  public Viagem(double distancia, double tempo) {
    if (distancia >= 0) this.distancia = distancia;
    if (tempo > 0) this.tempo = tempo;
  }
  public void SetDistancia(double distancia) {
    if (distancia >= 0) this.distancia = distancia;
  }
  public void SetTempo(double tempo) {
    if (tempo > 0) this.tempo = tempo;
  }
  public double GetDistancia() {
    return this.distancia; // return distancia;
  }
  public double GetTempo() => this.tempo;
  public double VelocidadeMedia() => this.distancia/this.tempo;
  public override string ToString() {
    return $"Distância = {distancia} km, Tempo = {tempo} h";
  } // Polimorfismo
}

class Pessoa : object {
}
class Usuario : object {
  private string login, password;
}
class Aluno : Pessoa {
  private Usuario usuario;
}
class Professor : Pessoa {
}