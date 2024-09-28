using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Oobj.src.Entities
{
    public abstract class Villiain : Character
    {
        public Villiain(string Name, int Level, string HeroType,string Race, string Nature,bool VillianBoss): base(Name, Level, HeroType)
        {
            this.Race = Race;
            this.NatureOfPower = Nature;
            this.Boss = VillianBoss;
        }
        public string Race { get; set; }
        public string NatureOfPower { get; set; }
        public bool Boss { get; set; }

        public override string CharacterSheet()
        {
            if(this.Boss)
                return $"{NameCharacter} {LevelCharacter} {TypeCharacter} {Race} {NatureOfPower} {NatureOfPower} + Vilão chefe";

            return $"{NameCharacter} {LevelCharacter} {TypeCharacter} {Race} {NatureOfPower} {NatureOfPower} + Inimigo normal";

        }
    }
}