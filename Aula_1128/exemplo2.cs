using System;
class Program {
  public static void Main() {
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Console.WriteLine(v[0]);
    v[0] = 100;
    for (int i = v.Length - 1; i >= 0; i--)
      Console.WriteLine(v[i]);

    int[,] m = new int[2,3];
    m[0,0] = 5;
    m[0,1] = 8;
    m[0,2] = 3;
    m[1,0] = 4;
    m[1,1] = 5;
    m[1,2] = 1;
    for(int i = 0; i < 2; i++) {
      for(int j = 0; j < 3; j++) 
        Console.Write(m[i,j] + " ");
      Console.WriteLine();
    }
    Console.WriteLine(m.Length);
    Console.WriteLine(m.Rank);
    Console.WriteLine(m.GetLength(0));
    Console.WriteLine(m.GetLength(1));
  }
}
