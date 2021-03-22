using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO {
  class TempoDobby : IRun
  {
    public void Run()
    {
      int RestoTempo = Int32.Parse(Console.ReadLine());
      int []TempoProducao = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToArray();
      Console.WriteLine((TempoProducao[0] + TempoProducao[1] > RestoTempo)?"Deixa para amanha!":"Farei hoje!");
    }
  }
}
