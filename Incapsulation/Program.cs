using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Program
    {     

        static void Main(string[] args)
        {
            //Car car = new Car();

            //while (true)
            //{
            //    string input;
            //    int fuel;
            //    Console.WriteLine("Введите колличество топлива:");
            //    input = Console.ReadLine();

            //    if (!Int32.TryParse(input, out fuel))
            //    {
            //        Console.Clear();
            //        continue;
            //    }

            //    try
            //    {
            //        car.Fuel = fuel;
            //        break;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.Clear();
            //        Console.WriteLine(e.Message);                    
            //    }
            //}

            //Console.WriteLine(car.Fuel);

            Fraction fraction = new Fraction(12,14);
            Fraction fraction1 = new Fraction(1, 2);

            

            Console.WriteLine(fraction + fraction1);
        }
    }
}
