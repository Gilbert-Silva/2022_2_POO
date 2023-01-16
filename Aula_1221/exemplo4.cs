using System;

class Program {
  public static void Main () {
    try {
      Metodo1();    
    }
    catch (MeuErro x) {
      Console.WriteLine(x.GetMensagem());
    }
    catch {
      Console.WriteLine("Sorry. Error found!");
    }
  }
  public static void Metodo1() {
    Metodo2();    
  }
  public static void Metodo2() {
    int a = 10;
    int b = 2;
    Console.WriteLine(a/b);
    throw new MeuErro("Mensagem do erro");
  }
}

class MeuErro : Exception {
  private string mensagem;
  public MeuErro(string msg) {
    mensagem = msg;
  }
  public string GetMensagem() {
    return mensagem;
  }
}