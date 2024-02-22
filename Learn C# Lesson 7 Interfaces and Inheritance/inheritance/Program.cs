// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace LearnInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      
      Truck t = new Truck(45, 500);
      
      Bicycle b = new Bicycle(10);

      Console.WriteLine(s.Describe());
      Console.WriteLine(t.Describe());
      Console.WriteLine(b.Describe());
      
    }
  }
}