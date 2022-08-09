namespace Figures.Figures;

public interface IFigure<T> where T: struct
{
    public T GetArea();
}