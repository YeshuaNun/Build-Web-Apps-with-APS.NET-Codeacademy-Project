// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");

      PasswordManager pm = new PasswordManager("iluvpie", true);

      Console.WriteLine("FIRST DISPLAY");
      tdl.Display();
      pm.Display();
      Console.WriteLine("BREAK");
      tdl.Reset();
      pm.Reset();
      Console.WriteLine("SECOND DISPLAY");
      tdl.Display();
      pm.Display();
      
    }
  }
}