using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

/// <summary>
/// Represents a rectangle as a polygon.
/// </summary>
class Rectangle : Polygon
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class.
    /// </summary>
    /// <param name="a">Length of the first side (width).</param>
    /// <param name="b">Length of the second side (height).</param>
    /// <param name="color">Figure color.</param>
    public Rectangle(double a, double b, ConsoleColor color)
    {
        Type = "Прямоугольник";
        Sides = new[] { a, b };
        Color = color;
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public override double GetArea() => Sides[0] * Sides[1];
}
