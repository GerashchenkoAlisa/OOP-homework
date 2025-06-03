using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

/// <summary>
/// Represents a triangle as a polygon.
/// </summary>
class Triangle : Polygon
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class.
    /// </summary>
    /// <param name="a">Length of the first side.</param>
    /// <param name="b">Length of the second side.</param>
    /// <param name="c">Length of the third side.</param>
    /// <param name="color">Figure color.</param>
    public Triangle(double a, double b, double c, ConsoleColor color)
    {
        Type = "Triangle";
        Sides = new[] { a, b, c };
        Color = color;
    }

    /// <summary>
    /// Calculates the area of the triangle using Heron's formula.
    /// </summary>
    /// <returns>The area of the triangle.</returns>
    public override double GetArea()
    {
        double p = Sides.Sum() / 2;
        return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
    }
}
