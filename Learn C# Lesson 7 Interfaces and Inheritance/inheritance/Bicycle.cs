using System;

// namespace LearnInheritance
// {
//     class Bicycle : Vehicle
//     {
//         public Bicycle(double speed) : base(speed)
//         {
//             Speed = speed;
//             Wheels = 2;
//         }
//         public override void SpeedUp()
//         {
//             Speed+=5;
//             if (SpeedUp>15) {
//                 Speed = 15;
//             }
//         }
//         public override void SlowDown()
//         {
//             Speed-=5;
//             if (SpeedUp<0) {
//                 Speed=0;
//             }
//         }
//     }
// }

namespace LearnInheritance
{
  class Bicycle : Vehicle
  {

    public Bicycle(double speed) : base(speed)
    {
      Wheels = 2;
    }

    public override void SpeedUp()
    {
      Speed += 5;
      
      if (Speed > 15)
      {
        Speed = 15;
      }
    }

    public override void SlowDown()
    {
      Speed -= 5;

      if (Speed < 0)
      {
        Speed = 0;
      }
    }

    public override string Describe()
    {
        return $"This bicycle is moving on {this.Wheels} wheels at {this.Speed} km/h, with license plate {this.LicensePlate}";
    }
  }
}