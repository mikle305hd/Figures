using System.ComponentModel.DataAnnotations;

namespace Figures.Validators;

public class CircleValidator: IFigureValidator<float>
{
    public void Validate(params float[] args)
    {
        if (args[0] <= 0)
            throw new ValidationException("Radius length must be more than 0.");
    }
}