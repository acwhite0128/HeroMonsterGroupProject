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

            //Rolls for their attack stat
            hero.Attack(dice);
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
        }
    }
}
