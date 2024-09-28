using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Oobj.src.Entities
{
    public interface IVilliainBoss
    {
        int DifficultyLevel { get; set; } // Nível de dificuldade
        string Stage { get; set; } // Fase ou ambiente onde o vilão aparece
        string Reward { get; set; } // Recompensa ao derrotar o vilão

        void Attack();
        void UseSpecialAbility(string ability);
    }
}