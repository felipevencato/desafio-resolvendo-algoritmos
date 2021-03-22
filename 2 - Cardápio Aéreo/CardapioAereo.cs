using System;
using System.Linq;
using System.Collections.Generic;
namespace DIO {
  class CardapioAereo : IRun
  {
    public void Run()
    {
      var QtdComida = new Queue<int>(Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToArray());
      Console.WriteLine(Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).Sum(QtdPedidos => Math.Max(0, QtdPedidos - QtdComida.Dequeue())));
    }
  }
}
