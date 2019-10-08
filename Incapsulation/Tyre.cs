using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Tyre
    {
        private readonly double MAX_PRESSURE;
        private readonly double MIN_PRESSURE;
        private double currentPressure;

        public Tyre()
        {
            MAX_PRESSURE = 2.5;
            MIN_PRESSURE = 2.1;
            currentPressure = 2.2;
        }

        public bool CheckPressure()
        {
            //bool isNormal = true;
            if (currentPressure > MAX_PRESSURE || currentPressure < MIN_PRESSURE)
            {
                //isNormal = false;
                return false;
            }
            //return isNormal;
            return true;
        }
    }
}
