using BasicTurnBaseFight.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTurnBaseFight.Players
{
    internal class Enemy :IPerson
    {
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int AttackDamage { get; set; }
        public int Race { get; set; }

        public int HunterAttackDamageCalc()
        {
            throw new NotImplementedException();
        }

        public int KnightAttackDamageCalc()
        {
            throw new NotImplementedException();
        }

        public int MageAttackDamageCalc()
        {
            throw new NotImplementedException();
        }
    }
}

