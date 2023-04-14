using System;
using System.Threading;

namespace CalcApp
{

  class Program
  {
    static void Main(string[] args)
    {
      Menu();


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
      Console.ReadKey();
      Menu();
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
      Console.ReadKey();
      Menu();

    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 / v2;

      Console.WriteLine("");

      Console.WriteLine($"O resultado é : {resultado}");
      Console.ReadKey();
      Menu();


    }

    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 * v2;
      Console.WriteLine($"Resultado é igual a : {resultado}");
      Console.ReadKey();
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("wait...");
      Thread.Sleep(1000);
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Go!");
      Thread.Sleep(1000);
      Console.WriteLine("Escolha a opção desejada: ");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("-----------------");
      short selection = short.Parse(Console.ReadLine());


      switch (selection)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Divisao();
          break;
        case 4:
          Multiplicacao();
          break;
        case 0:
          System.Environment.Exit(0);
          break;
        default:
          Console.WriteLine("Opção inválida. Tente novamente.");
          Thread.Sleep(2000);
          Menu();
          break;
      }
    }
  }





}





