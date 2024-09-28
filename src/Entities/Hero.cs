using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Oobj.src.Entities
{
    public abstract class Hero : Character
    {      


        public Hero(string Name, int Level, string HeroType,string Race, string Nature): base(Name, Level, HeroType)
        {
            this.Race = Race;
            this.NatureOfPower = Nature;
        }

        public string Race { get; set; }
        public string NatureOfPower { get; set; }

        public override string CharacterSheet()
        {
            return $"{NameCharacter} {LevelCharacter} {TypeCharacter} {Race} {NatureOfPower}";

        }


    }
}