using System;

/// <summary>
/// Represents an airplane, which is a type of transport.
/// </summary>
public class Airplane : Transport
{
    /// <summary>
    /// Starts the airplane and outputs a message indicating it has taken off.
    /// </summary>
    public void Start()
    {
        Console.WriteLine("The plane flew");
    }
}
