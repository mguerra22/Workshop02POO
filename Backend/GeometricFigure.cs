using System.Globalization;

namespace GeometricFigure.Backend;

public abstract class GeometricFigures
{
    // Constructors

    protected GeometricFigures(string name)
    {
        Name = name;
    }

    // Properties

    public string Name { get; set; }

    // Public Methods

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return string.Format(
            CultureInfo.InvariantCulture,
            "{0,-15} => Area.....: {1,15:N5}    Perimeter: {2,15:N5}",
            Name,
            GetArea(),
            GetPerimeter());
    }
}