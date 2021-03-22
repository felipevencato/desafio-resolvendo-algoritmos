using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO {
  class PizzaAntesFinalAno : IRun
  {
    public void Run()
    {
    var Dado = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x.ToString())).ToArray();

    while (Dado[1]-- != 0){
        string []aux = Console.ReadLine().Split(' ');
        if (aux.Skip(1).All(y => y == "1"))
        {
            Console.WriteLine(aux[0]);
            return;
        }
    }
    
    Console.WriteLine("Pizza antes de FdA");
  }
}
}
