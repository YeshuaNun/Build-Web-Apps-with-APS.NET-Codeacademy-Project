// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile(
        "Sam Brakkila",
        30,
        "New York",
        "USA",
        "he/him"
      );
    sam.SetHobbies(new[] {
         "listening to audiobooks and podcasts",
         "playing rec sports like bowling and kickball",
         "writing a speculative fiction novel",
         "reading advice columns"
       });
      Console.WriteLine(sam);
      Console.WriteLine(sam.ViewProfile());
    }
  }
}