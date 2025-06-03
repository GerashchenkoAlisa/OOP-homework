using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

/// <summary>
/// Represents a circle on the coordinate plane.
/// </summary>
class Circle : Figure
{
    /// <summary>
    /// X coordinate of the circle center.
    /// </summary>
    public double X { get; }

    /// <summary>
    /// Y coordinate of the circle center.
    /// </summary>
    public double Y { get; }

    /// <summary>
    /// Radius of the circle.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="x">X coordinate of the center.</param>
    /// <param name="y">Y coordinate of the center.</param>
    /// <param name="r">Radius of the circle.</param>
    /// <param name="color">Figure color.</param>
    public Circle(double x, double y, double r, ConsoleColor color)
    {
        Type = "Circle";
        X = x;
        Y = y;
        Radius = r;
        Color = color;
    }

    /// <summary>
    /// Calculates the area of the circle.
    /// </summary>
    /// <returns>The area of the circle.</returns>
    public override double GetArea() => Math.PI * Radius * Radius;

    /// <summary>
    /// Calculates the circumference of the circle.
    /// </summary>
    /// <returns>The circumference of the circle.</returns>
    public double GetLength() => 2 * Math.PI * Radius;

    /// <summary>
    /// Checks if the circle is completely located in the first quadrant.
    /// </summary>
    /// <returns>True if the circle is fully in the first quadrant; otherwise, false.</returns>
    public bool IsInFirstQuadrant() => X - Radius >= 0 && Y - Radius >= 0;
}
