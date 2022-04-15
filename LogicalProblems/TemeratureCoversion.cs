using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class TemeratureCoversion
    {
        double Celsius, Farhenite;
        public void CelsiusToFarhenite()
        {
            Console.WriteLine("Enter temperature in Celsius : ");
            Celsius = Convert.ToDouble(Console.ReadLine());

            Farhenite = (Celsius * 9 / 5) + 32;
            Console.WriteLine("The temperature in Farhenite : "+ Farhenite);
        }
        public void FarheniteToCelsius()
        {
            Console.WriteLine("Enter temperature in Farhenite : ");
            Farhenite = Convert.ToDouble(Console.ReadLine());

            Celsius = (Farhenite -32) * 5/9;
            Console.WriteLine("The temperature in Celsius : " + Celsius);
        }
    }
}
