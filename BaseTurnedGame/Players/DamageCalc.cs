using BasicTurnBaseFight.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTurnBaseFight.Players
{
    public class DamageCalc : GameManager
    {
        public static int KnightAttackDamageCalc()
        {
            Random rnd = new Random();
            int rndAttack = rnd.Next(1, 30);
            return rndAttack;
        }
    }
}
