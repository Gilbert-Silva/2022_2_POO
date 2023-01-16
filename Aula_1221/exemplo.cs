using System;

class Program {
  public static void Main () {
    Console.WriteLine("Qual o jogo: 1-Bingo, 2-Mega");
    int op = int.Parse(Console.ReadLine());
    ISorteio jogo;
    if (op == 1) { // Bingo
      jogo = new Bingo(15);
      for(int i = 0; i < 15; i++)
        Console.WriteLine(jogo.Proximo());
    }
    if (op == 2) { // Mega
      jogo = new Mega();
      for(int i = 0; i < 6; i++)
        Console.WriteLine(jogo.Proximo());
    }
  }
}

interface ISorteio {
  int Proximo();
  int[] Sorteados();
}

class Mega : ISorteio {
  private int[] vetor = new int[6]; // números já sorteados
  private int k;                    // qtd de números já sorteados
  public int Proximo() {
    // https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
    Random r = new Random();
    int n = r.Next(1, 61); 
    int pos = Array.IndexOf(vetor, n);
    while (pos != -1) {
      n = r.Next(1, 61);
      pos = Array.IndexOf(vetor, n);
    }
    vetor[k++] = n;
    return n;
  }
  public int[] Sorteados() {
    int[] temp = new int[k];
    Array.Copy(vetor, temp, k);
    return temp;
  }
  
}

class Bingo : ISorteio {
  private int numBolas = 1;
  private int[] vetor; // números já sorteados
  private int k;       // qtd de números já sorteados
  public Bingo(int numBolas) {
    if (numBolas > 0) this.numBolas = numBolas;
    vetor = new int[numBolas];
    k = 0;
  }
  public int Proximo() {
    // https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
    Random r = new Random();
    int n = r.Next(1, numBolas+1); 
    int pos = Array.IndexOf(vetor, n);
    while (pos != -1) {
      n = r.Next(1, numBolas+1);
      pos = Array.IndexOf(vetor, n);
    }
    vetor[k++] = n;
    return n;
  }
  public int[] Sorteados() {
    int[] temp = new int[k];
    Array.Copy(vetor, temp, k);
    return temp;
  }
}
