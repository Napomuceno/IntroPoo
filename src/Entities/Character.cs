using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Oobj.src.Entities
{
    public abstract class Character
    {
        public Character(string Name, int Level, string Type)
        {
            this.NameCharacter = Name;
            this.LevelCharacter = Level; 
            this.TypeCharacter =  Type;
        }

        public string NameCharacter { get; set; }
        public int LevelCharacter { get; set; }
        public string TypeCharacter { get; set; }

        public override string ToString()
        {
            return $"{NameCharacter} {LevelCharacter} {TypeCharacter}";
        }

        public  virtual  string Attack()
        {
            return this.NameCharacter + " Atacou com a sua espada";
        }

        public virtual string CharacterSheet()
        {
            return $"{NameCharacter} {LevelCharacter} {TypeCharacter}";

        }

    }
}