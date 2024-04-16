//----------------------------Task 1-------------------------------
public abstract class Figure
{
    public virtual double SquareCalculation(double a,double b)
    {
        return 1;
    }
}
public class Triangle: Figure
{
    public override double SquareCalculation(double a, double h)
    {
        double s = (a * h) / 2;
        double p = a + a + a;
        // S = (a * h) / 2
        // P = a + b + c
        Console.WriteLine($"Square = {s}, Perimeter = {p}");
        return p;
    }
}
public class Rectangle: Figure
{
    public override double SquareCalculation(double a, double b)
    {
        double s = a * b;
        double p = 2 * (a + b);
        // S = a * b
        // P = 2 * (a + b)
        Console.WriteLine($"Square = {s}, Perimeter = {p}");
        return p;
    }
}
public class Circle: Figure
{
    public override double SquareCalculation(double r, double pi)
    {
        double s = pi * (r * r);
        double p = 2 * pi * r;
        // S = pi * (r * r)
        // P = 2 * pi * r
        Console.WriteLine($"Square = {s}, Perimeter = {p}");
        return p;
    }
}
