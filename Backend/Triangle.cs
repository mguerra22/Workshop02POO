namespace GeometricFigure.Backend;

public class Triangle : Rectangle
{
    // Fields

    private double _c;
    private double _h;

    // Constructors

    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
    }

    // Properties

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Public Methods

    public override double GetArea() => (B * H) / 2;

    public override double GetPerimeter() => A + B + C;

    // Private Methods

    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new Exception($"The value C: {c} is not valid.");
        }

        return c;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new Exception($"The value H: {h} is not valid.");
        }

        return h;
    }
}