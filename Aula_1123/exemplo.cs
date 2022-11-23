using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = 
      new CultureInfo("pt-BR");
                             
    Console.WriteLine("Informe a data de nascimento");
    string s = Console.ReadLine();
    DateTime dt = DateTime.Parse(s);
    Console.WriteLine(dt);
    Console.WriteLine(dt.DayOfWeek);
    TimeSpan ts = new TimeSpan(30, 0, 0, 0);
    dt = dt + ts;
    Console.WriteLine(dt);
    Console.WriteLine(dt.DayOfWeek);
    dt = dt + ts;
    Console.WriteLine(dt);
    Console.WriteLine(dt.DayOfWeek);
    // https://learn.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-7.0
    dt = new DateTime(2022, 11, 23);
    Console.WriteLine(dt);
    
      
  }
}