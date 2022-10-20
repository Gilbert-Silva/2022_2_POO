using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor inteiro");
    int i;
    while(int.TryParse(Console.ReadLine(), out i) == false)
      Console.WriteLine("Valor não é um inteiro. Digite novamente");
    Console.WriteLine(i);
    double x = AreaTriangulo(10, 20);
    double y = Program.AreaTriangulo(30, 20);
    double z = Figuras.AreaTriangulo(40, 20);
    double w = Figuras.AreaRetangulo(40, 20);
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    Console.WriteLine(w);
  }
  public static double AreaTriangulo(double b, double h) {
    double area = b * h / 2;
    return area;
  }
}

class Figuras {
  public static double AreaTriangulo(double b, double h) {
    double area = b * h / 2;
    return area;
  }
  public static double AreaRetangulo(double b, double h) {
    double area = b * h;
    return area;
  }
}