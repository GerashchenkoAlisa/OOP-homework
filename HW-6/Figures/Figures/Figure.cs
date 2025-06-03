using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Represents the abstract base class for all geometric figures.
/// </summary>
abstract class Figure
{
    /// <summary>
    /// Gets or sets the type of the figure.
    /// </summary>
    public string Type { get; protected set; }

    /// <summary>
    /// Gets or sets the color of the figure.
    /// </summary>
    public ConsoleColor Color { get; protected set; }

    /// <summary>
    /// Calculates the area of the figure.
    /// </summary>
    /// <returns>The area of the figure.</returns>
    public abstract double GetArea();
}
