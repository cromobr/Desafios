using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class Operators
    {
        private static int solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double calculate_tip_percent = meal_cost *((double)tip_percent / 100);
            double calculate_tap_percent = meal_cost * ((double)tax_percent / 100);
            double sumTotal = meal_cost + calculate_tap_percent + calculate_tip_percent;
            return Convert.ToInt32(Math.Round(sumTotal));

        }
        /*
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(solve(meal_cost, tip_percent, tax_percent));
        }*/
    }
}
