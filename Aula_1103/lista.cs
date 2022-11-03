using System;

class Lista {
  private No raiz = null;
  private No ult  = null;
  public void Inserir(string valor) {
    No novo = new No(valor);
    if (raiz == null) { // Primeiro nó
      raiz = novo;      // raiz é o primeiro
      ult = novo;       // último é o primeiro
    }
    else {
      ult.SetProx(novo);  // próximo do último é o novo
      ult = novo;  // novo é o novo último
    }
  }
  public void Listar() {
    // Imprimir todos os nós da lista
  }
}

class No {
  private No prox;
  private string valor;
  public No(string valor) {
    this.valor = valor;
    this.prox = null;
  }
  public void SetProx(No no) {
    this.prox = no;
  }
}

class Program {
  public static void Main() {
    Lista x = new Lista();
    x.Inserir("Python");
    x.Inserir("C#");
    
  }
}
