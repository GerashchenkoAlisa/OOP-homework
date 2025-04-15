using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car1
{
    public class Car
    {
        private const int MaxFuel = 50;
        private const int MaxSpeed = 200;

        private string brand;
        private int speed;
        private int fuel;

        /// <summary>
        /// Initializes a new car with the specified brand.
        /// </summary>
        /// <param name="brand"></param>
        public Car(string brand)
        {
            this.brand = brand;
            speed = 0;
            fuel = 0;
        }

        /// <summary>
        /// Returns the brand of the car.
        /// </summary>
        /// <returns></returns>
        public string Brand()
        {
            return brand;
        }

        /// <summary>
        /// Returns the current speed of the car.
        /// </summary>
        /// <returns></returns>
        public int Speed()
        {
            return speed;
        }

        /// <summary>
        /// Returns the current fuel level of the car.
        /// </summary>
        /// <returns></returns>
        public int FuelLevel()
        {
            return fuel;
        }

        /// <summary>
        /// Refuels the car with the specified amount of fuel.
        /// </summary>
        /// <param name="liters"></param>
        public void Refuel(int liters)
        {
            if (liters > 0)
            {
                fuel += liters;
                if (fuel > MaxFuel)
                {
                    fuel = MaxFuel;
                }
            }
            else
            {
                Console.WriteLine("Enter a positive amount of fuel: ");
            }
        }

        /// <summary>
        /// Accelerates the car by the specified value, consuming fuel in the process.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fuelConsumptionRate"></param>
        public void Accelerate(int value, int fuelConsumptionRate)
        {
            if (fuel > 0)
            {
                speed += value;
                if (speed > MaxSpeed)
                {
                    speed = MaxSpeed;
                }

                fuel -= value / fuelConsumptionRate;
                if (fuel < 0)
                {
                    fuel = 0;
                }
            }
            else
            {
                Console.WriteLine("There is no fuel to accelerate");
            }
        }
    }
}
