public class Car
{
    private string brand;
    private int speed;
    private int fuel;

    /// <summary>
    /// Initializes a new element of the Car class with the specified brand.
    /// </summary>
    public Car(string Brand)
    {
        brand = Brand;
        speed = 0;
        fuel = 0;
    }

    /// <summary>
    /// Brand of the car.
    /// </summary>
    public string Brand()
    {
        return brand;
    }

    /// <summary>
    /// Current speed of the car.
    /// </summary>
    public int Speed()
    {
        return speed;
    }

    /// <summary>
    /// Current fuel level of the car.
    /// </summary>
    public int FuelLevel()
    {
        return fuel;
    }

    /// <summary>
    /// Refuels the car with the specified amount of fuel.
    /// </summary>
    public void Refuel(int liters)
    {
        if (liters > 0)
        {
            fuel += liters;
            if (fuel > 50)
            {
                fuel = 50;
            }
        }
        else
        {
            Console.WriteLine("Enter a positive amount of fuel: ");
        }
    }

    /// <summary>
    /// Accelerates the car by the specified value.
    /// </summary>
    public void Accelerate(int value)
    {
        if (fuel > 0)
        {
            speed += value;
            if (speed > 200)
            {
                speed = 200;
            }

            fuel -= value / 10;
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