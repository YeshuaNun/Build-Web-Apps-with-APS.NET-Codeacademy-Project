// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
        double areaTeotihucan = (AreaTri(750, 500))+(AreaRec(2500, 1500))+(0.5*AreaCir(375/2));
        double floorCost = 180;
        double areaTeotihucanCost = Math.Round(areaTeotihucan*floorCost, 2);
        Console.WriteLine($"The total area of the Teotihucan is {areaTeotihucan}.\nThe flooring cost is {floorCost} Mexican pesos.\nThe total cost is {areaTeotihucanCost} Mexican pesos.");
    }
    static double AreaRec(double length, double width)
    {
        return length*width;
    }
    static double AreaCir(double radius)
    {
        return Math.PI*Math.Pow(radius, 2);
    }
    static double AreaTri(double bottom, double height)
    {
        return 0.5*bottom*height;
    }
  }
}