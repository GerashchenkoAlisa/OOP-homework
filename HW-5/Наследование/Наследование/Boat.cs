using System;

/// <summary>
/// Represents a boat, which is a type of transport.
/// </summary>
public class Boat : Transport
{
    /// <summary>
    /// Starts the boat and outputs a message indicating it has started sailing.
    /// </summary>
    public void Start()
    {
        Console.WriteLine("The boat sailed");
    }
}