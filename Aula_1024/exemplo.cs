using System;

class Program {
  public static void Main() {
    //int x;
    //Console.WriteLine(x);

    // identidade
    Triangulo t = new Triangulo();
    Console.WriteLine(t.GetBase());
    Console.WriteLine(t.GetAltura());
    // estado
    //t.b = 10.5; 
    //t.h = -20;
    t.SetBase(10.5);
    t.SetAltura(-20);
    Console.WriteLine(t.GetBase());
    Console.WriteLine(t.GetAltura());
    // comportamento
    Console.WriteLine("Área = " + t.CalcArea());
    Triangulo y = new Triangulo();
    y.SetBase(10);
    y.SetAltura(2);
    Console.WriteLine("Área = " + y.CalcArea());
    y = null;
    Triangulo z = null;
    // Console.WriteLine(z.CalcArea());
    z = new Triangulo();
    if (z != null) 
      Console.WriteLine(z.CalcArea());
  }
}

class Triangulo {
  // encapusulamento
  private double b = 1, h = 1; // campo ou atributos
  public void SetBase(double valor) {
    if (valor > 0) b = valor;
  }
  public void SetAltura(double valor) {
    if (valor > 0) h = valor;
  }
  public double GetBase() {
    return b;
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {  // método
    double area = b * h / 2;
    return area;
  }
}