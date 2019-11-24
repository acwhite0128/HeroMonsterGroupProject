using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterGroupProject
{
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public Character(string name, int health, int damageMaximum, bool attackBonus)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Health = health;
            DamageMaximum = damageMaximum;
            AttackBonus = attackBonus;
        }

        public int Attack(Dice dice)
        {
            return dice.Roll(this.DamageMaximum);
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }

    }
}
