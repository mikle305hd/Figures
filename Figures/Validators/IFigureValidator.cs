namespace Figures.Validators;

public interface IFigureValidator<in T>
{
    public void Validate(params T[] args);
}