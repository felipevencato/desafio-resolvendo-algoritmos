using System;
namespace DIO {
  class HoraCorrida : IRun
  {
    public void Run()
    {
      string[] line = Console.ReadLine().Split(' ');
      int Voltas = Int32.Parse(line[0]);
      int Placas = Int32.Parse(line[1]);
      int total = Voltas * Placas;
      for (int i = 1; i < 10;i++){
        double saida = (double)total * i * 0.1;
        Console.Write($"{Math.Ceiling(saida)} ");
      }
    }
  }
}
