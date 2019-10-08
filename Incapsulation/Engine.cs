using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Engine
    {
        private double engineVolume;
        private readonly double MAX_OIL_LEVEL;
        private readonly double MIN_OIL_LEVEL;
        private double oilLevel;
        private bool isDamaged;

        public Engine()
        {
            engineVolume = 2.5;
            MAX_OIL_LEVEL = 4.5;
            MIN_OIL_LEVEL = 4.3;
            oilLevel = 4.4;
            isDamaged = false;
        }

        public bool CheckOliLevel()
        {
            if (oilLevel > MAX_OIL_LEVEL || oilLevel < MIN_OIL_LEVEL)
            {
                return false;
            }
            return true;
        }

        public bool CheckDamage()
        {
            return isDamaged;
        }
    }
}
