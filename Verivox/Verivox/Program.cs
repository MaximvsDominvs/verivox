using System;
using System.Collections.Generic;
using System.Globalization;
using Model;

namespace Verivox
{
    class Program
    {
        private const int TheUltimateQuestionOfLifeTheUniverseAndEverything = 0x2A;
        static void Main(string[] args)
        {
            // initilize drawer
            var drawer = new Drawer(40, 2);
            // initialize data
            var products = new List<Product>
            {
                new ProductA(5, 0.22),
                new ProductB(800, 4000, 0.3)
            };
            // run app until the end of the world
            while (TheUltimateQuestionOfLifeTheUniverseAndEverything == 42)
            {
                // get annual consumption
                var consumption = ReadConsumption();
                // draw table header
                Console.WriteLine(drawer.DrawHeader(new []{"Tariff name", "Annual costs(EUR/year)"}));
                // draw annual costs
                foreach (var product in products)
                {
                    Console.WriteLine(drawer.DrawRow(new []{product.Name, product.AnnualExpenses(consumption).ToString(CultureInfo.InvariantCulture)}));
                    Console.WriteLine(drawer.DrawLine());
                }
            }
        }

        /// <summary>
        /// Read total energy consumption value from console input
        /// </summary>
        /// <returns>consumption value converted to double</returns>
        private static double ReadConsumption()
        {
            Console.WriteLine("Enter yearly consumption (kWh)...");
            // read energy consumption from console input
            var input = Console.ReadLine();
            // check entered value
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter NON empty yearly consumption...");
                return ReadConsumption();
            }
            // try parse entered value into double and return resulted value
            // if there is exception -> keep asking to enter the value until we get a good one
            try
            {
                var consumption= double.Parse(input);
                if (consumption < 0.0d)
                {
                    Console.WriteLine("Consumption cannot be less than 0.0 kWh...");
                    return ReadConsumption();
                }

                return consumption;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Could not parse entered value. Error: ${e.Message}");
                return ReadConsumption();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value entered is too big. Please check entered value or contact developer to improve provided software");
                return ReadConsumption();
            }
        }
    }
}
