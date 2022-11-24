using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = 
      new CultureInfo("pt-BR");

    DateTime dt = DateTime.Now;
    Console.WriteLine(dt);
    Console.WriteLine($"{dt:dd/MM/yy}");
    Console.WriteLine($"{dt:dd/MM/yyyy}");
    Console.WriteLine($"{dt:dd/MMM/yyyy}");
    Console.WriteLine($"{dt:dd/MMMM/yyyy}");
    Console.WriteLine($"{dt:dd/MM/yy hh:mm:ss}");
    Console.WriteLine($"{dt:ddd}");
    Console.WriteLine($"{dt:dddd}");
    Console.WriteLine(dt.DayOfWeek);

  }
}