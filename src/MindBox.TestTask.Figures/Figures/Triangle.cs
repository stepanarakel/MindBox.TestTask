using MindBox.TestTask.Figures.Figures.Abstractions;
using static MindBox.TestTask.Figures.Configuration.AppConstants;

namespace MindBox.TestTask.Figures.Figures;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : Figure
{
    /// <summary>
    /// Конструктор <see cref="Triangle"/>.
    /// </summary>
    /// <param name="a">Сторона A.</param>
    /// <param name="b">Сторона B.</param>
    /// <param name="c">Сторона C.</param>
    /// <exception cref="ArgumentException">Длинны сторон не могут быть отрицательными.</exception>
    /// <exception cref="ArgumentException">По длиннам сторон невозможно построить треугольник.</exception>
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException(ExceptionMessages.TriangleExceptionMessages.LengthsOfSidesCannotBeNegative);
        if (a + b < c || b + c < a || a + c < b)
            throw new ArgumentException(ExceptionMessages.TriangleExceptionMessages.TriangleInequalityDoesTotHold);

        SideA = a;
        SideB = b;
        SideC = c;
    }

    /// <summary>
    /// Сторона A.
    /// </summary>
    public double SideA { get; }

    /// <summary>
    /// Сторона B.
    /// </summary>
    public double SideB { get; }

    /// <summary>
    /// Сторона C.
    /// </summary>
    public double SideC { get; }

    /// <summary>
    /// Является ли треугольник прямоугольным.
    /// </summary>
    /// <param name="triangle">Треугольник (по умолчанию <see cref="Accuracy"/>).</param>
    /// <param name="accuracy">Точность</param>
    /// <returns>true - трегольник является прямоугольным, иначе - false.</returns>
    public static bool IsRectangularTriangle(Triangle triangle, double accuracy = Accuracy)
    {
        var descOrderedSides = new[] { triangle.SideA, triangle.SideB, triangle.SideC }.OrderDescending().ToArray();
        var result = Math.Abs(Math.Pow(descOrderedSides[0], 2) - descOrderedSides[1..3].Select(x => Math.Pow(x, 2)).Sum());
        return result.CompareTo(accuracy) <= 0;
    }

    /// <inheritdoc />
    public override double GetArea()
        => IsRectangularTriangle(this) ? GetAreaOfRectangularTriangle(this) : GetAreaOnThreeSides(this);

    /// <summary>
    /// Получить площадь прямоугольного треугольника.
    /// </summary>
    /// <param name="triangle">Треугольник.</param>
    /// <returns>Площадь треугольника.</returns>
    private static double GetAreaOfRectangularTriangle(Triangle triangle)
    {
        var descOrderedSides = new[] { triangle.SideA, triangle.SideB, triangle.SideC }.OrderDescending().ToArray();
        var area = descOrderedSides[1] * descOrderedSides[2] / 2;
        return area;
    }

    /// <summary>
    /// Получить площадь треугльника по 3-м сторонам.
    /// </summary>
    /// <param name="triangle">Треугольник.</param>
    /// <returns>Площадь треугольника.</returns>
    private static double GetAreaOnThreeSides(Triangle triangle)
    {
        var p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
        var area = Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
        return area;
    }
}