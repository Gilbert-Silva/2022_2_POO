using System;
class Program {
  public static void Main() {
    int[] x = new int[10] { 5, 3, 9, 0, 1, 2, 7, 8, 4, 6 };
    // i é o elemento
    foreach(int i in x) Console.Write(i + " ");
    Console.WriteLine();
    // elem é o elemento
    foreach(int elem in x) Console.Write(elem + " ");
    Console.WriteLine();
    // i é o índice
    // x[i] é o elemento
    for (int i = 0; i < 10; i++) Console.Write(x[i] + " ");
    Console.WriteLine();
    for (int i = 0; i < 10; i++)
      Console.WriteLine(i + " " + x[i] + " ");
    // elementos de índice par
    for (int i = 0; i < 10; i += 2)
      Console.WriteLine(i + " " + x[i] + " ");
  }
}