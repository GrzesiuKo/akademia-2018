using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        private int hp = 100;
        private string weapon = "sword";


        public void Strike(Monster monster)
        {
            if (weapon.Equals("sword"))
            {
                monster.Hp -= 100;
                if (monster.Hp <= 0)
                {
                    monster.IsAlive = false;
                }
            }

            Console.WriteLine("Monster is now: " + monster.IsAlive);
        }

        

    }
}
