using System;

class Program {
  public static void Main () {
    int[] x = { 10, 20, 30 };
    Console.WriteLine(x[0]);
    Console.WriteLine(x[1]);
    Console.WriteLine(x[2]);
    // Console.WriteLine(x[3]); - Index
    string s = "Teste";
    // Console.WriteLine(s[5]); - Index
    // Console.WriteLine(s.Substring(0, 6)); - Argument
    s = null;
    Console.WriteLine(s);
    // Console.WriteLine(s.Substring(0, 6)); - Null
    //int y = 10;
    //Console.WriteLine(y[0]);
    object a = new Aluno();
    Aluno b = (Aluno) a;
    // Professor c = (Professor) a; - InvalidCast
  }
}

class Aluno {
  
}
class Professor {
  
}