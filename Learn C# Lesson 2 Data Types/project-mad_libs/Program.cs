// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program asks the user to input a series of words such as nouns, verbs, and adjectives etc based on prompts fromthe program. Once all the inputs been assigned a story is printed with the custom words chosen by the user.
      Author: Joshua Brooks
      */
      // Let the user know that the program is starting:
      Console.WriteLine("This is the start of this story. Follow the instructions and input your values based on the information requested.");
      // Give the Mad Lib a title:
      string title = "You're bespoke MadLib story!";
      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      Console.Write("Choose your first adjective: ");
      string firstAdj = Console.ReadLine();
      Console.Write("Choose your second adjective: ");
      string secondAdj = Console.ReadLine();
      Console.Write("Choose your third adjective: ");
      string thirdAdj = Console.ReadLine();
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();
      Console.Write("Choose your first noun: ");
      string firstNoun = Console.ReadLine();
      Console.Write("Choose your second noun: ");
      string secondNoun = Console.ReadLine();
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Enter the name of a superhero: ");
      string superhero = Console.ReadLine();
      Console.Write("Enter the name of a country: ");
      string country = Console.ReadLine();
      Console.Write("Enter the name of a dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Enter a year: ");
      string year = Console.ReadLine();
      // The template for the story:
      string story = $"This morning {name} woke up feeling {firstAdj}. 'It is going to be a {secondAdj} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdj}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";
      // Print the story:
      Console.WriteLine(story);
    }
  }
}