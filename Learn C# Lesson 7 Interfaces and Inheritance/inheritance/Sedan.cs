using System;

// namespace LearnInheritance
// {
//   class Sedan : IAutomobile
//   {
//   	public string LicensePlate
//     { get; }

//     public double Speed
//     { get; private set; }

//     public int Wheels
//     { get; }
    
//     public Sedan(double speed)
//     {
//       Speed = speed;
//       LicensePlate = Tools.GenerateLicensePlate();
//       Wheels = 4;
//     }
    
//     public void Honk()
//     {
//       Console.WriteLine("HONK!");
//     }
    
//     public void SpeedUp()
//     {
//       Speed += 5;
//     }

//     public void SlowDown()
//     {
//       Speed -= 5;
//     }
    
//   }
// }

// namespace LearnInheritance
// {
//   class Sedan : Vehicle, IAutomobile
//   { 
//     public Sedan(double speed)
//     {
//       Speed = speed;
//       LicensePlate = Tools.GenerateLicensePlate();
//       Wheels = 4;
//     }    
//   }
// }

// namespace LearnInheritance
// {
//   class Sedan : Vehicle, IAutomobile
//   {
//     public Sedan(double speed)
//     {
//       Speed = speed;
//       LicensePlate = Tools.GenerateLicensePlate();
//       Wheels = 4;
//     }
    
//   }
// }

// namespace LearnInheritance
// {
//   class Sedan : Vehicle, IAutomobile
//   {
//     public Sedan(double speed) : base(speed)
//     {
//       Wheels = 4;
//     }    
//   }
// }

namespace LearnInheritance
{
  class Sedan : Vehicle, IAutomobile
  {
    public Sedan(double speed) : base(speed)
    {
      Wheels = 4;
    }
    public override string Describe()
    {
        return $"This sedan is moving on {this.Wheels} wheels at {this.Speed} km/h, with license plate {this.LicensePlate}";
    }
  }
}