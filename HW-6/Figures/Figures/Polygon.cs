using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Represents an abstract polygon figure.
/// </summary>
abstract class Polygon : Figure
{
    /// <summary>
    /// Gets the array of side lengths of the polygon.
    /// </summary>
    public double[] Sides { get; protected set; }
}
