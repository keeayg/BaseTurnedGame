using BasicTurnBaseFight.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTurnBaseFight.Players
{
    public class Player : IPerson
    {
        public int Hp { get; set; }
        public int Mana { get; set; }

        public int AttackDamage { get; set; }

        public int Race { get; set; }

        public int KnightAttackDamageCalc()
        {
            Random rnd = new Random();
            int rndAttack = rnd.Next(1, 30);
            return rndAttack;
        }

        public int HunterAttackDamageCalc()
        {
            Random rnd = new Random();
            int rndAttack = rnd.Next(1, 30);
            return rndAttack;
        }

        public int MageAttackDamageCalc()
        {
            Random rnd = new Random();
            int rndAttack = rnd.Next(1, 30);
            return rndAttack;
        }

        


    }
}

