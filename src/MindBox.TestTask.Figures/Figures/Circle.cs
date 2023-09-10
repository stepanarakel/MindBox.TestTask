using MindBox.TestTask.Figures.Figures.Abstractions;
using static MindBox.TestTask.Figures.Configuration.AppConstants.ExceptionMessages.CircleExceptionMessages;

namespace MindBox.TestTask.Figures.Figures;

/// <summary>
/// Круг.
/// </summary>
public class Circle : Figure
{
    /// <summary>
    /// Конструктор <see cref="Circle"/>.
    /// </summary>
    /// <param name="radius">Радиус.</param>
    /// <exception cref="ArgumentException">Радиус не может быть отрицательным.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException(RadiusCannotBeNegative);
        Radius = radius;
    }

    /// <summary>
    /// Радиус.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Диаметр.
    /// </summary>
    public double Diameter => Radius * 2;

    /// <summary>
    /// Длинна окружности.
    /// </summary>
    public double Length => Diameter * Math.PI;

    /// <inheritdoc />
    public override double GetArea()
        => GetAreaByRadius(this);

    /// <summary>
    /// Получить площадь по радиусу.
    /// </summary>
    /// <param name="circle">Круг.</param>
    /// <returns>Площадь круга.</returns>
    private static double GetAreaByRadius(Circle circle)
        => Math.PI * Math.Pow(circle.Radius, 2);
}