﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
        MonsterHead();
        GhostBody();
        BugFeet();
        BuildACreature("monster", "ghost", "bug");
        SwitchCase(1, 1, 1);
        RandomMode();
    }
    
    static void BuildACreature(string head, string body, string feet)
    {
        // switch (head) {
        //     case "ghost":
        //     GhostHead();
        //     break;
        //     case "bug":
        //     BugHead();
        //     break;
        //     case "monster":
        //     MonsterHead();
        //     break;
        // }
        // switch (body) {
        //     case "ghost":
        //     GhostBody();
        //     break;
        //     case "bug":
        //     BugBody();
        //     break;
        //     case "monster":
        //     MonsterBody();
        //     break;
        // }
        // switch (feet) {
        //     case "ghost":
        //     GhostFeet();
        //     break;
        //     case "bug":
        //     BugFeet();
        //     break;
        //     case "monster":
        //     MonsterFeet();
        //     break;
        // }

        int headNum = TranslateToNumber(head);
        int bodyNum = TranslateToNumber(body);
        int feetNum = TranslateToNumber(feet);
        SwitchCase(headNum, bodyNum, feetNum);
    }

    static void RandomMode()
    {
        Random randomNumber = new Random();

        int head = randomNumber.Next(1, 4);
        int body = randomNumber.Next(1, 4);
        int feet = randomNumber.Next(1, 4);
        SwitchCase(head, body, feet);
    }

    static void SwitchCase(int head, int body, int feet)
    {
        switch (head) {
            case 1:
            GhostHead();
            break;
            case 2:
            BugHead();
            break;
            case 3:
            MonsterHead();
            break;
        }
        switch (body) {
            case 1:
            GhostBody();
            break;
            case 2:
            BugBody();
            break;
            case 3:
            MonsterBody();
            break;
        }
        switch (feet) {
            case 1:
            GhostFeet();
            break;
            case 2:
            BugFeet();
            break;
            case 3:
            MonsterFeet();
            break;
        }
    }

    static int TranslateToNumber(string creature)
    {
        switch (creature) {
            case "ghost":
            return 1;
            case "bug":
            return 2;
            case "monster":
            return 3;
            default:
            return 1;
        }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }

  }
}