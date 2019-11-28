using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterGroupProject
{
    class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();

        public int Roll(int sides)
        {
            return random.Next(sides);
        }
    }
}
