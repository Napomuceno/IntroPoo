using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Oobj.src.Entities
{
    public class Necromante : Villiain, IVilliainBoss
    {
        public Necromante(string Name, int Level, string HeroType, string Race, string Nature, bool VillianBoss) : base(Name, Level, HeroType, Race, Nature, VillianBoss)
        {
            string _nature = Nature;
        }

       

        private const string V = " Trevas";
        private int _difficultyLevel;
        public int DifficultyLevel 
        { 
            get 
            {
                // Retorna o valor ajustado se for 10
                if (_difficultyLevel * 5 > 50)
                    return _difficultyLevel * 5;
        
                // Retorna o valor normal
                return _difficultyLevel; 
            }
    
            set 
            {
                // Define um valor padrão de 50 se o valor inserido for menor que 50
                if (value < 50)
                {
                    _difficultyLevel = 50;
                }
                else
                {
                    _difficultyLevel = value;
                }
            } 
        }
        private string _stage = "Chamas das trevas"; // Campo privado para armazenar o valor

        public string Stage 
        { 
            get => _stage; // Retorna o valor do campo privado
            set => _stage = value; // Define o valor do campo privado
        
        }
        public string Reward { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void UseSpecialAbility(string ability)
        {
            throw new NotImplementedException();
        }

        void IVilliainBoss.Attack()
        {
            throw new NotImplementedException();
        }


        public string FullSheet()
        {
            string Sheet=$" Nome:{NameCharacter}  \n Level :{LevelCharacter}  \n Classe :{TypeCharacter}";
            Sheet +=$"\n Raça:{Race}  \n Natureza do poder :{NatureOfPower}  ";
            Sheet +=$"\n Nivel Força:{DifficultyLevel}  \n Nivel Defesa :{DifficultyLevel+10}  ";
            Sheet +=$"\n Poder Supremo: Amaterazo  ";
            Sheet +=$"\n Endo Tensei:Invocação dos mortos  ";
            Sheet +=$"\n Lugar de controle:{Stage} \n ";

            return Sheet;
        }
    }
}