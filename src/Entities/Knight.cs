using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace _06_Oobj.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType,string Race, string Nature): base(Name, Level, HeroType, Race, Nature)    
        {
            
        }

        public int LevelPower { get; set; }
        public int  LevelDefense{ get; set; }

        public bool ContainsSword { get; set; }

        public bool DualBlades { get; set; }

        public string  NameSword{ get; set; }

        public string  NameDualblades{ get; set; }



        public int PowerDanager(int LevelPower, int PoweBonus=0)
        {
            if(PoweBonus > 0 ){
                LevelPower =LevelPower+PoweBonus;
            }

            int DanagerPower = LevelPower;

            if(ContainsSword)
            {
                DanagerPower = (LevelPower*2);
            }
            else if(DualBlades){
                DanagerPower = (LevelPower*4);
            }

            return DanagerPower;
        }
 

        public  override  string Attack()
        {
            int DanagerPower = PowerDanager(LevelPower);

            if(this.DualBlades)
                return $"{NameCharacter}   Atacou com a sua Dual Blades  {this.NameDualblades} de  nivel de poder  {this.LevelPower} dano causado {DanagerPower} ";
            else if(this.ContainsSword)
                return $"{NameCharacter}  Atacou com a sua espada {this.NameSword} de  nivel de poder  {this.LevelPower} dano causado {DanagerPower} ";
            else
                return $"{NameCharacter}  Atacou com soco de  nivel de poder {this.LevelPower} dano causado com os socos {DanagerPower} ";

        }

        public string Attack(int PoweBonus)
        {
            int DanagerPower = PowerDanager(LevelPower,PoweBonus);

            if(this.DualBlades)
                return $"{NameCharacter}   Atacou com a sua Dual Blades  {this.NameDualblades} de  nivel de poder  {this.LevelPower} dano causado {DanagerPower} Super ";
            else if(this.ContainsSword)
                return $"{NameCharacter}   Atacou com a sua espada {this.NameSword} de  nivel de poder  {this.LevelPower} dano causado {DanagerPower} Super";
            else
                return $"{NameCharacter}   Atacou com soco de  nivel de poder {this.LevelPower} dano causado com os socos {DanagerPower} Super ";

        }
        
        public string FullSheet()
        {
            string Sheet=$" Nome:{NameCharacter}  \n Level :{LevelCharacter}  \n Classe :{TypeCharacter}";
            Sheet +=$"\n Raça:{Race}  \n Natureza do poder :{NatureOfPower}  ";
            Sheet +=$"\n Nivel Força:{LevelPower}  \n Nivel Defesa :{LevelDefense}  ";

            if(this.DualBlades)
                Sheet +=$"\n Nome da Dual Blades:{NameDualblades} \n ";
            else if(this.ContainsSword)
                Sheet +=$"\n Nome da Espada:{NameSword} \n ";
            else
                Sheet +=$"\n So na porrda mesmo aqui \n ";

            return Sheet;
        }
        


    }
}