using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public string Title{get; private set;}
        public Mage(string title) : base(title){
            Title = title;
        }
        public Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
}