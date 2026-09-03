namespace GeometricFigure.Backend;

public class Circle : GeometricFigures
{
    // Fields

    private double _r;

    // Constructors

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    // Properties

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Public Methods

    public override double GetArea() => Math.PI * _r * _r;

    public override double GetPerimeter() => 2 * Math.PI * _r;

    // Private Methods

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new Exception($"The value R: {r} is not valid.");
        }

        return r;
    }
}