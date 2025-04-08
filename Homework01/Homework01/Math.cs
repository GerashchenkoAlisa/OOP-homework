using ArrayDoing;

internal class Calculator
{
    public static double Calculate(int a, int b, int c)
    {
        return (2 * Math.Sin(a) + 3 * b * Math.Pow(Math.Cos(c), 3)) / (a + b);
    }
}
