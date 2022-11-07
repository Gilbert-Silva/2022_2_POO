using System;

class Program {
  public static void Main() {
    Conversor c = new Conversor(45);
    Console.WriteLine(c.Binario());
    c.SetNum(46);
    Console.WriteLine(c.Binario());
    c.SetNum(1023);
    Console.WriteLine(c.Binario());
    c.SetNum(1024);
    Console.WriteLine(c.Binario());
    Console.WriteLine(c);
  }
}

class Conversor {
  private int num;  // decimal
  public Conversor(int num) {
    if (num >= 0) this.num = num;
  }
  public void SetNum(int num) {
    if (num >= 0) this.num = num;
  }
  public int GetNum() {
    return num;
  }
  public string Binario() {
    string s = "";
    int x = num;
    while (x != 0) {
      s = (x % 2).ToString() + s;
      x = x / 2;
    }
    return s;
  }
  public override string ToString() {
    return $"({num})10 = ({Binario()})2";
  }
}