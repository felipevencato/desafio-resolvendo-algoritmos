using System;

namespace DIO {
  class ConversaoTempo : IRun
  {
    public void Run()
    {
      double Dado = Int32.Parse(Console.ReadLine()), Hora = 0, Minuto = 0, Segundo = 0;
      Hora = Math.Floor(Dado/(60*60));
      Dado -= Hora * 60 * 60;
      Minuto = Math.Floor(Dado/(60));
      Dado -= Minuto * 60;
      Segundo = Dado;
      Console.WriteLine($"{Hora}:{Minuto}:{Segundo}");
    }
  }
}
