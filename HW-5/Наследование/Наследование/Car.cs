using System;

/// <summary>
/// Represents a car, which is a type of transport.
/// </summary>
public class Car : Transport
{
    /// <summary>
    /// Starts the car and outputs a message indicating it has started moving.
    /// </summary>
    public void Start()
    {
        Console.WriteLine("The car went");
    }
}