﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957);

      // Rover[] rovers = {lunokhod, apollo, sojourner};
      // DirectAll(rovers);

      Object[] probes = {lunokhod, apollo, sojourner, sputnik};
      foreach (Object probe in probes) {
        Console.WriteLine($"Tracking a {probe.GetType()}.");
      }

      IDirectable[] newProbes = {lunokhod, apollo, sojourner, sputnik};
      DirectAll(newProbes);
    }

    public static void DirectAll(IDirectable[] probes) {
        foreach (IDirectable probe in probes) {
            Console.WriteLine(probe.GetInfo());
            Console.WriteLine(probe.Explore());
            Console.WriteLine(probe.Collect());
        }
    } 
  }
}