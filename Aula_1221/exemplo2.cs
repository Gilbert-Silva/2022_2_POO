using System;

class Program {
  public static void Main () {
    int a, b, c = 0;
    Console.WriteLine("Digite 2 valores inteiros");
    // https://learn.microsoft.com/en-us/dotnet/api/system.int32?view=net-7.0
    try {
      a = int.Parse(Console.ReadLine());
      b = int.Parse(Console.ReadLine());
      c = a/b;
    }
    /*
    catch (FormatException) {
      Console.WriteLine("Valor digitado não é um número inteiro");
    }
    catch (OverflowException) {
      Console.WriteLine("Valor digitado é muito grande");
    }
    */
    catch (Exception r) {
      Console.WriteLine(r.GetType().ToString() + " - " + r.Message);
    }
    // https://learn.microsoft.com/pt-br/dotnet/api/system.dividebyzeroexception?view=net-7.0
    Console.WriteLine(c);
  }
}
