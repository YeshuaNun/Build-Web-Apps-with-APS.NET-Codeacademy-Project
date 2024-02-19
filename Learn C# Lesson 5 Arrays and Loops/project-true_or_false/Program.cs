// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);
      // Type your code below
      string[] questions = {
        "Polar Bears are WHITE...",
        "Carrots are ORANGE...",
        "Paper is BLACK..."
      };
      bool[] answers = {
        true,
        true,
        false
      };
      bool[] responses = new bool[answers.Length];
      if (questions.Length!=answers.Length) {Console.WriteLine("You do not have the same number of answers as there are questions.");}
      int askingIndex = 0;
      foreach (string question in questions) {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.WriteLine("True or false?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        while (isBool==false) {
            Console.WriteLine("Please respond with 'True' or 'False'.");
            input = Console.ReadLine();
            isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex]=inputBool;
        askingIndex++;
      }
      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers) {
        bool response = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex+1}. Input: {response}| Answer: {answer}");
        if (response==answer) {score++;}
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {answers.Length} correct!");
    }
  }
}