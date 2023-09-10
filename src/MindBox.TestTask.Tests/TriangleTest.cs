using MindBox.TestTask.Figures.Figures;
using static MindBox.TestTask.Figures.Configuration.AppConstants.ExceptionMessages.TriangleExceptionMessages;

namespace MindBox.TestTask.Tests;

/// <summary>
/// Тест треугольника.
/// </summary>
public class TriangleTest
{
    private static readonly Random Random = new();

    /// <summary>
    /// Проверить ограничение отрицательных длин сторон треугольника.
    /// </summary>
    [Fact(DisplayName = "Проверить ограничение отрицательных длин сторон треугольника.")]
    public void CheckLimitationOfNegativeLengthsOfTrianglesSides()
    {
        var action = () => new Triangle(-1, 2, 3);
        var exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal(LengthsOfSidesCannotBeNegative, exception.Message);
    }

    /// <summary>
    /// Проверить неравенство треугольника.
    /// </summary>
    [Fact(DisplayName = "Проверить неравенство треугольника.")]
    public void CheckTriangleInequality()
    {
        var action = () => new Triangle(10, 2, 3);
        var exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal(TriangleInequalityDoesTotHold, exception.Message);
    }

    /// <summary>
    /// Проверить является треугольник прямоугольным.
    /// </summary>
    [Fact(DisplayName = "Проверить является треугольник прямоугольным.")]
    public void IsTriangleRectangular()
    {
        var a = Random.Next(1, 10);
        var b = Random.Next(1, 10);
        var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        var triangle = new Triangle(a, b, c);
        Assert.True(Triangle.IsRectangularTriangle(triangle));
    }
}