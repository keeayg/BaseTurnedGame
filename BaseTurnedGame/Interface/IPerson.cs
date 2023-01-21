using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTurnBaseFight.Interface
{
    public interface IPerson
    {
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int AttackDamage { get; set;}
        int Race { get; set; }

        int KnightAttackDamageCalc();
        int HunterAttackDamageCalc();
        int MageAttackDamageCalc();

        
    }
}
