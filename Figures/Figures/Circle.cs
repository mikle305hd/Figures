using Figures.Validators;

namespace Figures.Figures;

public class Circle: IFigure<float>
{
    private float _radius;
    private float _area;
    private readonly IFigureValidator<float> _validator;

    public float Radius
    {
        get => _radius;
        set
        {
            _validator.Validate(value);
            _radius = value;
            _area = CalculateArea(value);
        }
    }

    public Circle(float radius)
    {
        _validator = new CircleValidator();
        _validator.Validate(radius);
        _radius = radius;
        _area = CalculateArea(radius);
    }
    
    public float GetArea()
    {
        return _area;
    }

    private float CalculateArea(float radius)
    {
        return (float)(Math.PI * Math.Pow(radius, 2));
    }
}