using System;

class Program {
  public static void Main() {
    int i = 10;
    Console.WriteLine(i);
    Console.WriteLine(i.GetType());
    double d;
    d = 2.5;
    Console.WriteLine(d.GetType());
    string s = "Teste";
    Console.WriteLine(s.GetType());
    bool b = true;
    Console.WriteLine(b.GetType());
    char c = 'x';
    Console.WriteLine(c.GetType());
    Console.WriteLine(2 + 2);
    Console.WriteLine("2" + "2");
    Console.WriteLine('2' + '2');
    // string w = 'a';
    // Conversão implícita
    double x = 1;
    Console.WriteLine(x); 
    Console.WriteLine(x.GetType()); 
    // Conversão explícita
    int y = (int) 1.5;
    Console.WriteLine(y);  
    // Formatação de números reais
    double z = 1.56836092702938703694709;
    Console.WriteLine(z);  
    Console.WriteLine($"{z:f1}");  
    Console.WriteLine($"{z:f2}");  
    Console.WriteLine($"{z:f3}");  
    Console.WriteLine($"{z:f4}");  
    Console.WriteLine($"{z:f10}");  
    Console.WriteLine($"{z:f20}");  
    Console.WriteLine($"{z:f30}");  
    Console.WriteLine($"{z:0.0}");  
    Console.WriteLine($"{z:0.00}");  
    Console.WriteLine($"{z:0.000}");  
    Console.WriteLine($"{z:0.0000}");  
    // Limites de números reais
    int t = 2000000000;
    Console.WriteLine(t);
    Console.WriteLine(t + t);
    t = 2147483647;
    Console.WriteLine(t);
    Console.WriteLine(t+1);
    long u = 2000000000;
    Console.WriteLine(u);
    Console.WriteLine(u + u);
    // Formatação de inteiros
    int dia = 29;
    int mes = 02;
    int ano = 2022;
    Console.WriteLine($"{dia:00}/{mes:00}/{ano}");
    // Entrada e Saída
    Console.WriteLine("Teste");
    string v = Console.ReadLine();
    Console.WriteLine(v);
    Console.WriteLine(v.GetType());
    int q = int.Parse(Console.ReadLine());
    Console.WriteLine(q);
    Console.WriteLine(q.GetType());
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine(r);
    Console.WriteLine(r.GetType());
    string sr = r.ToString();
    Console.WriteLine(sr.GetType());
    // Divisão inteira e divisão real
    Console.WriteLine(6/4);
    Console.WriteLine(6.0/4);
    Console.WriteLine(6/4.0);

    
  }
}