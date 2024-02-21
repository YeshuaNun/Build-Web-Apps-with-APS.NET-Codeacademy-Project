// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace LearnInterfaces
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Sedan s = new Sedan(60);
//       Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
//       s.Honk();
//     }
//   }
// }

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
        Sedan sedanA = new Sedan(60);
        Sedan sedanB = new Sedan(70);
        Truck truckA = new Truck(45, 500);

        Console.WriteLine($"Sedan A has a speed of {sedanA.Speed}, with {sedanA.Wheels} wheels and has a license plate of {sedanA.LicensePlate}.");
        Console.WriteLine($"Sedan B has a speed of {sedanB.Speed}, with {sedanB.Wheels} wheels and has a license plate of {sedanB.LicensePlate}.");
        Console.WriteLine($"Truck A has a speed of {truckA.Speed}, with {truckA.Wheels} wheels and has a license plate of {truckA.LicensePlate}.");

        sedanA.SpeedUp();
        sedanB.SpeedUp();
        truckA.SpeedUp();

        Console.WriteLine($"Sedan A has a speed of {sedanA.Speed}, with {sedanA.Wheels} wheels and has a license plate of {sedanA.LicensePlate}.");
        Console.WriteLine($"Sedan B has a speed of {sedanB.Speed}, with {sedanB.Wheels} wheels and has a license plate of {sedanB.LicensePlate}.");
        Console.WriteLine($"Truck A has a speed of {truckA.Speed}, with {truckA.Wheels} wheels and has a license plate of {truckA.LicensePlate}.");
    }
  }
}