using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player bartek = new Player();
            Monster mon = new Monster(50, false);

            bartek.Strike(mon);

            Orc ork = new Orc(50);
            Console.WriteLine(ork.Hp);
            Console.ReadKey();
        }
    }
}
