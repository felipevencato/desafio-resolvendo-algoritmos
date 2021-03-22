using System;

namespace DIO {
  class IdadeDias : IRun
  {
    public void Run()
    {
      double IdadeEmDias = int.Parse(Console.ReadLine()), Anos = 0, Meses = 0, Dias = 0;
      Anos = Math.Floor(IdadeEmDias/365);
      IdadeEmDias -= Anos * 365;
      Meses = Math.Floor(IdadeEmDias/(30));
      IdadeEmDias -= Meses * 30;
      Dias = IdadeEmDias;
      Console.WriteLine($"{Anos} ano(s)\n{Meses} mes(es)\n{Dias} dia(s)");
    }
  }
}
