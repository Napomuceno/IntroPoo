using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Oobj.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType,string Race, string Nature): base(Name, Level, HeroType, Race, Nature)    
        {
            
        }

        public int LevelPowerMagic { get; set; }
        public int  LevelDefense{ get; set; }

        public bool MagicStaff { get; set; }

        public bool MagicWand { get; set; }

        public string  NameMagicStaff{ get; set; }

        public string  NameMagicWand{ get; set; }
        

        public int PowerDanager(int LevelPowerMagic, int PoweBonus=0)
        {
            if(PoweBonus > 0 ){
                LevelPowerMagic =LevelPowerMagic+PoweBonus;
            }

            int DanagerPower = LevelPowerMagic;

            if(MagicStaff)
            {
                DanagerPower = (LevelPowerMagic*2);
            }
            else{
                DanagerPower = (LevelPowerMagic*4);
            }

            return DanagerPower;
        }

        

        public   override string Attack()
        {
            int DanagerPower = PowerDanager(LevelPowerMagic);           

            if(this.MagicStaff)
                 return NameCharacter + " Lançou Magia, Com o cajado "+NameMagicStaff +"Dano gerado " + DanagerPower ;
            
            return NameCharacter + " Lançou Magia, Com a varinha "+NameMagicWand +"Dano gerado " + DanagerPower ;

        }

        public    string Attack(int Bonus)
        {
            int DanagerPower = PowerDanager(LevelPowerMagic,Bonus);  

            if(Bonus > 6){
               return this.NameCharacter + " Lançou Magia  Super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.NameCharacter + " Lançou Magia  com forca fraca com bonus de  " + Bonus;

            }  
            
        }

        public string FullSheet()
        {
            string Sheet=$" Nome:{NameCharacter}  \n Level :{LevelCharacter}  \n Classe :{TypeCharacter}";
            Sheet +=$"\n Raça:{Race}  \n Natureza do poder :{NatureOfPower}  ";
            Sheet +=$"\n Nivel Força:{LevelPowerMagic}  \n Nivel Defesa :{LevelDefense}  ";

            if(this.MagicStaff)
                Sheet +=$"\n Nome do cajado:{NameMagicStaff} \n ";
            else 
                Sheet +=$"\n Nome da Vara:{NameMagicWand} \n ";


            return Sheet;
        }
    }
}