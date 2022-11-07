using System;

class Program {
  public static void Main() {
    double x, y, z;
    Equacao eq = new Equacao(1, 0, 4);
    eq.GetABC(out x, out y, out z);
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    double r1, r2;
    if (eq.Raizes(out r1, out r2)) 
      Console.WriteLine($"Raízes são {r1} e {r2}");
    else
      Console.WriteLine("Não tem raízes reais");
  }
}

class Equacao {
  private double a = 1, b, c;
  public Equacao(double a, double b, double c) {
    // SetABC(a, b, c);
    if (a != 0) this.a = a;
    this.b = b;
    this.c = c;
  }
  public void SetABC(double a, double b, double c) {
    if (a != 0) this.a = a;
    this.b = b;
    this.c = c;
  }
  public void GetABC(out double a, out double b, out double c) {
    a = this.a;
    b = this.b;
    c = this.c;
    //return (a, b, c);
  }
  public double Delta() {
    return b*b - 4 * a * c;
  }
  public bool Raizes(out double x1, out double x2) {
    x1 = x2 = 0;
    double delta = Delta();
    if (delta >= 0) {
      x1 = (-b + Math.Sqrt(delta)) / (2 * a);
      x2 = (-b - Math.Sqrt(delta)) / (2 * a);
      return true;
    }
    return false;
  }
  
}