using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

/// <summary>
/// Entry point of the application.
/// </summary>
class Program
{
    /// <summary>
    /// Main method that demonstrates the creation, sorting, and display of geometric figures.
    /// </summary>
    static void Main()
    {
        // Create a list of various geometric figures.
        var figures = new List<Figure>
        {
            new Rectangle(3, 4, ConsoleColor.Red),
            new Triangle(3, 4, 5, ConsoleColor.Green),
            new Circle(5, 5, 2, ConsoleColor.Blue),
            new Circle(3, 3, 1, ConsoleColor.Green),
            new Rectangle(2, 6, ConsoleColor.Yellow),
            new Triangle(5, 5, 6, ConsoleColor.White),
            new Circle(1, 1, 0.5, ConsoleColor.Green)
        };

        // Sort polygons by area using OrderBy.
        var polygons = figures.OfType<Polygon>()
                              .OrderBy(p => p.GetArea())
                              .ToList();

        // Get all circles from the figures list.
        var circles = figures.OfType<Circle>()
                             .ToList();

        Console.WriteLine("Polygons:");
        Console.WriteLine("Type\t\tArea\tColor");
        foreach (var p in polygons)
        {
            Console.ForegroundColor = p.Color;
            Console.WriteLine($"{p.Type}\t{p.GetArea():F2}\t{p.Color}");
            Console.ResetColor();
        }

        Console.WriteLine("\nCircles:");
        Console.WriteLine("Length\tArea\tColor");
        foreach (var c in circles)
        {
            Console.ForegroundColor = c.Color;
            Console.WriteLine($"{c.GetLength():F2}\t{c.GetArea():F2}\t{c.Color}");
            Console.ResetColor();
        }

        // Find green circles whose centers are in the first quadrant.
        var greenCircles = circles
            .Where(c => c.Color == ConsoleColor.Green && c.IsInFirstQuadrant())
            .ToList();

        Console.WriteLine("\nGreen circles in the first quadrant:");
        foreach (var c in greenCircles)
            Console.WriteLine($"Length: {c.GetLength():F2}, Center: ({c.X}, {c.Y})");
        Console.ReadLine();
    }
}
