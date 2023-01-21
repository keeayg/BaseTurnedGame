using BasicTurnBaseFight.Interface;
using BasicTurnBaseFight.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTurnBaseFight.Game
{
    public class GameManager
    {
        IPerson playerPerson = new Player();
        IPerson enemyPerson = new Enemy();



        public void PlayerSelect()
        {

            Console.WriteLine("chose");
            Console.WriteLine("1- Knight");
            Console.WriteLine("2- Hunter");
            Console.WriteLine("3- Mage");

            var playerChoice = Convert.ToInt32(Console.ReadLine());
            playerPerson.Race = playerChoice;
            switch (playerChoice)
            {
                case 1: //Knight
                    playerPerson.Hp = 100;
                    playerPerson.Mana = 10;
                    Console.WriteLine("You Chose Knight");
                    Console.WriteLine($"Your Attributes:\n   Hp: {playerPerson.Hp}\n   Mana: {playerPerson.Mana}");

                    break;
                case 2: //Hunter
                    playerPerson.Hp = 60;
                    playerPerson.Mana = 10;
                    Console.WriteLine("You Chose Hunter");
                    Console.WriteLine($"Your Attributes:\n   Hp: {playerPerson.Hp}\n   Mana: {playerPerson.Mana}");
                    break;
                case 3: //Mage
                    playerPerson.Hp = 50;
                    playerPerson.Mana = 10;
                    Console.WriteLine("You Chose Mage");
                    Console.WriteLine($"Your Attributes:\n   Hp: {playerPerson.Hp}\n   Mana: {playerPerson.Mana}");
                    break;

                default:
                    break;
            }



        }
        public void EnemySelection()
        {
            Random rnd = new Random();
            int enemyNum = rnd.Next(1, 3);
            enemyPerson.Race = enemyNum;

            switch (enemyNum)
            {
                case 1: //Knight
                    enemyPerson.Hp = 100;
                    enemyPerson.Mana = 10;
                    Console.WriteLine("You will fight with Knight");
                    Console.WriteLine($"Enemy Attributes:\n   Hp: {enemyPerson.Hp}\n   Mana: {enemyPerson.Mana}");
                    break;
                case 2: //Hunter
                    enemyPerson.Hp = 60;
                    enemyPerson.Mana = 10;
                    Console.WriteLine("You will fight with Hunter");
                    Console.WriteLine($"Enemy Attributes:\n   Hp: {enemyPerson.Hp}\n   Mana: {enemyPerson.Mana}");
                    break;
                case 3: //Mage
                    enemyPerson.Hp = 50;
                    enemyPerson.Mana = 10;
                    Console.WriteLine("You will fight with Mage");
                    Console.WriteLine($"Enemy Attributes:\n   Hp: {enemyPerson.Hp}\n   Mana: {enemyPerson.Mana}");
                    break;

                default:
                    break;
            }


        }
        public void Fight()
        {
            while (playerPerson.Hp > 0 || enemyPerson.Hp > 0)
            {

                switch (playerPerson.Race)
                {
                    case 1: //Knight
                        playerPerson.AttackDamage = playerPerson.KnightAttackDamageCalc();
                        break;
                    case 2: //Hunter
                        playerPerson.AttackDamage = playerPerson.HunterAttackDamageCalc();
                        break;
                    case 3: //Mage
                        playerPerson.AttackDamage = playerPerson.MageAttackDamageCalc();
                        break;

                    default:
                        break;
                }

                switch (enemyPerson.Race)
                {
                    case 1: //Knight
                        enemyPerson.AttackDamage = playerPerson.KnightAttackDamageCalc();
                        break;
                    case 2: //Hunter
                        enemyPerson.AttackDamage = playerPerson.HunterAttackDamageCalc();
                        break;
                    case 3: //Mage
                        enemyPerson.AttackDamage = playerPerson.MageAttackDamageCalc();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Attack For 'a'");
                var attackChoice = Console.ReadLine();

                if (attackChoice == "a")
                {
                    enemyPerson.Hp -= playerPerson.AttackDamage;
                    Console.WriteLine($"You hit {playerPerson.AttackDamage} Enemy Hp: {enemyPerson.Hp}");
                    playerPerson.Hp -= enemyPerson.AttackDamage;
                    Console.WriteLine($"Enemy hits {enemyPerson.AttackDamage} Your Hp: {playerPerson.Hp}");
                    
                }


                if (playerPerson.Hp < 0)
                {
                    Console.WriteLine("YOU DİED...");
                    Console.WriteLine("Start Again..");
                    Console.WriteLine("y/n");
                    var ch = Console.ReadLine();
                    if (ch == "y") { PlayerSelect();}
                    
                }
                if (enemyPerson.Hp < 0)
                {
                    Console.WriteLine("YOU WİN!! CONGRATULATİONS!!!");
                    Console.WriteLine("Are you ready to fight again?");
                    Console.WriteLine("y/n");
                    var ch = Console.ReadLine();
                    if (ch == "y")
                    {
                        PlayerSelect();
                        EnemySelection();
                        FightStart();
                    }
                }
            }
        }
        public void FightStart()
        {
            Console.WriteLine("Are you ready?");
            Console.WriteLine("y/n");
            var playerChoice = Console.ReadLine();

            if (playerChoice == "y")
            {
                Fight();
            }
            else { PlayerSelect(); }
        }

    }
}
