using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Car
    {
        private string model;
        private string colour;
        private int fuel;
        private Engine engine;
        private Tyre[] tyres;

        public string Model { get => model; set => model = value; }
        public string Colour { get => colour; set => colour = value; }
        public int Fuel { get => fuel; set => fuel = (value <= 100) ? value: throw new Exception("Fuel over max limit!"); }

        public Car()
        {
            model = "VolksWagen";
            colour = "red";
            fuel = 100;
            engine = new Engine();
            tyres = new Tyre[4];
            for (int i = 0; i < tyres.Length; i++)
            {
                tyres[i] = new Tyre();
            }
            
        }

        private bool CheckTyres()
        {
            if (tyres == null)
            {
                return false;
            }

            if (tyres.Length != 4)
            {
                return false;
            }

            foreach (Tyre tyre in tyres)
            {
                if (tyre == null)
                {
                    return false;
                }

                if (tyre.CheckPressure() == false)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckEngine()
        {
            if (engine == null || !engine.CheckOliLevel() || engine.CheckDamage())
            {
                return false;
            }
            return true;
        }

        public void Drive()
        {
            if (!CheckTyres() || !CheckEngine() || fuel <= 0)
            {
                Console.WriteLine("Не едет!");
                return;
            }
            Console.WriteLine("Дыр-Дыр-Дыр!");
            fuel -= 20;
        }
    }
}
