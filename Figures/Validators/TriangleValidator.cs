using System.ComponentModel.DataAnnotations;

namespace Figures.Validators;

public class TriangleValidator: IFigureValidator<float>
{
    public void Validate(params float[] args)
    {
        if (args.Length != 3)
            throw new ValidationException("Triangle must have 3 sides.");
        if (args[0] <= 0 || args[1] <= 0 || args[2] <= 0)
            throw new ValidationException("Every side length must be more than 0.");
        if (args[0] + args[1] <= args[2] || args[1] + args[2] <= args[0] || args[0] + args[2] <= args[1])
            throw new ValidationException("Every side length must be less than sum of 2 other.");
    }
}