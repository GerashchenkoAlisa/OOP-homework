using System;

/// <summary>
/// The entry point of the application that demonstrates the usage of different types of transport.
/// </summary>
class Program
{
    /// <summary>
    /// The main method where the program execution begins.
    /// </summary>
    static void Main()
    {
        // Create and configure a car
        Car car = new Car();
        Console.WriteLine("Enter the speed for the car:");
        car.Speed = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the amount of fuel for the car:");
        car.Refuel(int.Parse(Console.ReadLine()));
        car.Start();

        // Create and configure a boat
        Boat boat = new Boat();
        Console.WriteLine("Enter the speed for the boat:");
        boat.Speed = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the amount of fuel for the boat:");
        boat.Refuel(int.Parse(Console.ReadLine()));
        boat.Start();

        // Create and configure an airplane
        Airplane airplane = new Airplane();
        Console.WriteLine("Enter the speed for the airplane:");
        airplane.Speed = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the amount of fuel for the airplane:");
        airplane.Refuel(int.Parse(Console.ReadLine()));
        airplane.Start();

        Console.ReadLine();
    }
}
