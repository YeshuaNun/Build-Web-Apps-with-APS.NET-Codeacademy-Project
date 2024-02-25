using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public string Title{get; private set;}
        public Archmage(string title) : base(title){
            Title = title;
        }
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }
        public Storm CastLightningStorm()
        {
            return new Storm("lighting", true, Title);
        }
    }
}