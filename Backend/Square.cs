namespace GeometricFigure.Backend;

public class Square : GeometricFigures
{
    // Fields

    private double _a;

    // Constructors

    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    // Properties

    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Public Methods

    public override double GetArea() => _a * _a;

    public override double GetPerimeter() => 4 * _a;

    // Private Methods

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new Exception($"The value A: {a} is not valid.");
        }

        return a;
    }
}