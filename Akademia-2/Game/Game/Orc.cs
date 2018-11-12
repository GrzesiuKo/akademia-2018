using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Orc : Monster
    {
        private int _liczbaMieczy;

        public int LiczbaMieczy {
            get {
                return _liczbaMieczy;
            }
            set {
                if ( value > 0)
                {
                    _liczbaMieczy = value;
                }
            }
        }

        public Orc(int hp) : base(hp)
        {
            
        }
    }
}
