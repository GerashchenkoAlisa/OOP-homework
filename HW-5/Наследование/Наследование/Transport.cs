using System;

/// <summary>
/// Represents a generic transport vehicle.
/// </summary>
public class Transport
{
    private int speed;
    private int FuelLevel;

    /// <summary>
    /// Gets or sets the speed of the transport.
    /// </summary>
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    /// <summary>
    /// Refuels the transport by the specified amount.
    /// </summary>
    /// <param name="amount">The amount of fuel to add.</param>
    public void Refuel(int amount)
    {
        FuelLevel += amount;
        Console.WriteLine($"The transport is refueled. Fuel level: {FuelLevel}");
    }
}