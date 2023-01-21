using BasicTurnBaseFight.Interface;
using BasicTurnBaseFight.Game;

namespace BasicTurnBaseFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager();

            gm.PlayerSelect();
            gm.EnemySelection();
            gm.FightStart();
            
        }
    }
}