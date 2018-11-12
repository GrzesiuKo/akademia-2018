using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster
    {
        public int Hp { get; set; }
        public bool IsAlive { get; set; }

        public Monster()
        {
            
        }

        public Monster(int hp)
        {
            this.Hp = hp;
            this.IsAlive = true;
        }

        public Monster(int hp, bool isAlive) : base()
        {
            this.Hp = hp;
            this.IsAlive = isAlive;
        }
    }
}
