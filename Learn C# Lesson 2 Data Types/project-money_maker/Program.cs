// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("How much money do you need to convert? ");
      string amountToConvert = Console.ReadLine();
      double amountToConvertAsDouble = Math.Floor(Convert.ToDouble(amountToConvert));
      Console.WriteLine($"{amountToConvert} in the smallest number of coins is equal to...");
      double numberGoldCoins = Math.Floor(amountToConvertAsDouble/10);
      double remainingAmount = amountToConvertAsDouble%10;
      double numberSilverCoins = Math.Floor(remainingAmount/5);
      double numberBronzeCoins = remainingAmount%5;
      Console.WriteLine($"Gold coins: {numberGoldCoins}");
      Console.WriteLine($"Silver coins: {numberSilverCoins}");
      Console.WriteLine($"Bronze coins: {numberBronzeCoins}");
    }
  }
}