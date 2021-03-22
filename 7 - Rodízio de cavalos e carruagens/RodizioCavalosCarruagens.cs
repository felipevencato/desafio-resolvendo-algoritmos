using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DIO {
  class RodizioCavalosCarruagens : IRun
  {
    public void Run()
    {
      Regex rx = new Regex(@"\b[A-Z]{3}-([0-9]{4}\b)",RegexOptions.Compiled);
      int Numero = Int32.Parse(Console.ReadLine());
      var Placas = new List<string>();
      
      for (int i = 0; i < Numero; i++)
        Placas.Add(Console.ReadLine());
        
      foreach (var p in Placas){
        if (rx.IsMatch(p))
          switch(p[p.Length - 1]){
          case '1': 
          case '2': Console.WriteLine("SEGUNDA");break;
          case '3': 
          case '4': Console.WriteLine("TERCA");break;
          case '5': 
          case '6': Console.WriteLine("QUARTA");break;
          case '7': 
          case '8': Console.WriteLine("QUINTA");break;
          case '9': 
          case '0': Console.WriteLine("SEXTA");break;
        }
        else Console.WriteLine("FALHA");
      }
    }
  }
}
