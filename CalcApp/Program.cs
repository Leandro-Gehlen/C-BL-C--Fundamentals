using System;
using System.Threading;

namespace CalcApp
{

  class Program
  {
    static void Main(string[] args)
    {
      Subtracao();
      Soma();


    }
    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;
      Console.WriteLine($"O resultado é: {resultado} ");
    }
    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;
      Console.WriteLine($"O resultado é {resultado}");

      Thread.Sleep(3000);
    }

  }



}





