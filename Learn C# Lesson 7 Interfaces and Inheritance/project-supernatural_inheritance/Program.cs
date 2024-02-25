// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
         Storm testStormA = new Storm(
            "wind", false, "Zul'rajas"
         );
         Console.WriteLine(testStormA.Announce());
         Pupil testPupilA = new Pupil("Mezil-kree");
         Storm testPupilACast = testPupilA.CastWindStorm();
         Console.WriteLine(testPupilACast.Announce());
         Mage testMageA = new Mage("Gul'dan");
         Storm testMageACast = testMageA.CastRainStorm();
         Console.WriteLine(testMageACast.Announce());
         Archmage testArchmageA = new Archmage("Nielas Aran");
         Storm testArchmageACastRain = testArchmageA.CastRainStorm();
         Storm testArchmageACastLightning = testArchmageA.CastLightningStorm();
         Console.WriteLine(testArchmageACastRain.Announce());
         Console.WriteLine(testArchmageACastLightning.Announce());     
    }
  }
}