public class Lista02Ex03 {
  public static void main(String[] args) {
    Viagem v1 = new Viagem();
    v1.setDistancia(350);
    v1.setTempo(4);
    System.out.println(v1.velocidadeMedia() + "km/h");
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
  public void setDistancia(double distancia) {
    if (distancia >= 0) this.distancia = distancia;
  }
  public void setTempo(double tempo) {
    if (tempo > 0) this.tempo = tempo;
  }
  public double getDistancia() {
    return this.distancia; // return distancia;
  }
  public double getTempo() {
    return this.tempo;
  }
  public double velocidadeMedia() {
    return this.distancia/this.tempo;
  }
  public String ToString() {
    return "Distância = {distancia} km, Tempo = {tempo} h";
  } 
}
