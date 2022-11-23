using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe os dados da 1ª peça");
    PecaDomino p1 = new PecaDomino(
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()));
    Console.WriteLine("Informe os dados da 2ª peça");
    PecaDomino p2 = new PecaDomino(
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()));
    Console.WriteLine(p1.Combinar(p2) ? "Peças combinam" : "Peças não combinam");
  }
}

class PecaDomino {
  private int x = 1, y = 1;
  public PecaDomino(int x, int y) {
    if (x >= 1 && x <= 6) this.x = x;
    if (y >= 1 && y <= 6) this.y = y;
    // Console não deve ser usado
  }
  public void SetX(int x) {
    if (x >= 1 && x <= 6) this.x = x;
  }
  public void SetY(int y) {
    if (y >= 1 && y <= 6) this.y = y;
  }
  public int GetX() {
    return x;
  }
  public int GetY() {
    return y;
  }
  public override string ToString() {
    return $"{x} {y}";
  }
  public bool Combinar(PecaDomino pd) {
    return x == pd.x || x == pd.y || y == pd.x || y == pd.y;
  }
}