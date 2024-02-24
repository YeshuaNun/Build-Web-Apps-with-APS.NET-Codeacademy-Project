using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence{get; private set;}
        public bool IsStrong{get; private set;}
        public string Caster{get; private set;}
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }
        public string Announce()
        {
            string strength = (IsStrong) ? "strong" : "weak";
            return $"{Caster} cast a {strength} {Essence} storm!";
        }
    }
}