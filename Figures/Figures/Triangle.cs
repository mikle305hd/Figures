using Figures.Validators;

namespace Figures.Figures;

public class Triangle : IFigure<float>
{
    private float[] _sides;
    private float _area;
    private readonly IFigureValidator<float> _validator;

    public float[] Sides
    {
        get => _sides;
        set
        {
            _validator.Validate(value);
            _sides = value;
            _area = CalculateArea(value[0], value[1], value[2]);
        }
    }

    public Triangle(float a, float b, float c)
    {
        _validator = new TriangleValidator();
        _validator.Validate(a, b, c);
        _sides = new[] { a, b, c };
        _area = CalculateArea(a, b, c);
    }

    public float GetArea()
    {
        return _area;
    }

    public bool IsRightTriangle()
    {
        return Math.Abs(Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) - Math.Pow(_sides[2], 2)) < 0.01;
    }

    private float CalculateArea(float a, float b, float c)
    {
        var semiPerimeter = (a + b) / 2;
        return (float)Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    }
}