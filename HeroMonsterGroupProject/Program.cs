using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created new objects
            Character hero = new Character("Kevin", 100, 20, false);
            Character monster = new Character("Gourg", 150, 15, true);
            Dice dice = new Dice();


            //the battle loop will break when a character's health is below 0
            while (hero.Health > 0 && monster.Health > 0)
            {

                monster.Attack(dice);

                //Logic to see if monster gets attack bonus
                if (monster.DamageMaximum >= 20)
                {
                    monster.AttackBonus = true;
                    monster.addDamage();
                    hero.Defend(monster.DamageMaximum);
                }
                else
                {
                    monster.AttackBonus = false;
                    hero.Defend(monster.DamageMaximum);
                }

                hero.Attack(dice);

                //logic to see if hero gets attack bonus
                if (hero.DamageMaximum >= 22)
                {
                    hero.AttackBonus = true;
                    hero.addDamage();
                    monster.Defend(hero.DamageMaximum);
                }
                else
                {
                    hero.AttackBonus = false;
                    monster.Defend(hero.DamageMaximum);
                }

                displayStats(hero, monster);

            }

            displayResult(hero, monster);
            Console.ReadLine();
        }
        public static void displayStats(Character opponent1, Character opponent2)
        {
            Console.WriteLine("{0} health: {1}", opponent1.Name, opponent1.Health);
            Console.WriteLine("{0} health: {1}\n", opponent2.Name, opponent2.Health);
            
        }

        public static void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health > 0)
                Console.WriteLine("{0} died, {1} wins!", opponent1.Name, opponent2.Name);

            else
                Console.WriteLine("Both {0} and {1} died.", opponent1.Name, opponent2.Name);

        }
    }
}

