using System;

// namespace LearnInheritance
// {
//     class Vehicle
//     {
//         public string LicensePlate {get;}
//         public double Speed {get; private set;}
//         public int Wheels {get;}
//         public void Honk()
//         {
//             Console.WriteLine("HONK!");
//         }
//         public void SpeedUp()
//         {
//             Speed+=5;
//         }
//         public void SlowDown()
//         {
//             Speed-=5;
//         }
//     }  
// }

// namespace LearnInheritance
// {
//   class Vehicle
//   {
//     public string LicensePlate
//     { get; protected set;}

//     public double Speed
//     { get; protected set; }

//     public int Wheels
//     { get; protected set;}

//     public void SpeedUp()
//     {
//       Speed += 5;
//     }

//     public void SlowDown()
//     {
//       Speed -= 5;
//     }
    
//     public void Honk()
//     {
//       Console.WriteLine("HONK!");
//     }

//   }
// }

// namespace LearnInheritance
// {
//   class Vehicle
//   {
//     public string LicensePlate
//     { get; private set; }

//     public double Speed
//     { get; private set; }

//     public int Wheels
//     { get; protected set; }

//     public void SpeedUp()
//     {
//       Speed += 5;
//     }

//     public void SlowDown()
//     {
//       Speed -= 5;
//     }
    
//     public void Honk()
//     {
//       Console.WriteLine("HONK!");
//     }

//     public Vehicle(double speed)
//     {
//         Speed = speed;
//         LicensePlate = Tools.GenerateLicensePlate();
//     }
//   }
// }

// namespace LearnInheritance
// {
//   class Vehicle
//   {
//     public string LicensePlate
//     { get; private set; }

//     public double Speed
//     { get; protected set; }

//     public int Wheels
//     { get; protected set; }

//     public Vehicle(double speed)
//     {
//       Speed = speed;
//       LicensePlate = Tools.GenerateLicensePlate();
//     }

//     public virtual void SpeedUp()
//     {
//       Speed += 5;
//     }

//     public virtual void SlowDown()
//     {
//       Speed -= 5;
//     }
    
//     public void Honk()
//     {
//       Console.WriteLine("HONK!");
//     }

//   }
// }

namespace LearnInheritance
{
  abstract class Vehicle
  {
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; protected set; }

    public int Wheels
    { get; protected set; }

    public Vehicle(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
    }

    public virtual void SpeedUp()
    {
      Speed += 5;
    }

    public virtual void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public abstract string Describe();
  }
}