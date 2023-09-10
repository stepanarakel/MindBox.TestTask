using MindBox.TestTask.Figures.Figures;
using MindBox.TestTask.Figures.Interfaces;

namespace MindBox.TestTask.Tests;

/// <summary>
/// Тест площади фигур.
/// </summary>
public class FigureAreaTest
{
    /// <summary>
    /// Проверить расчёт площади фигур.
    /// </summary>
    [Fact(DisplayName = "Проверить расчёт площади фигур.")]
    public void CheckCalculationOfFiguresAreas()
    {
        var figureAreas = new Dictionary<double, IFigureArea>
        {
            { 64.0625, new Triangle(10, 13, 15) },
            { 60, new Triangle(10, 12, 15.62059935) },
            { 314.1593, new Circle(10) }
        };

        foreach (var figureArea in figureAreas)
            Assert.True(figureArea.Value.GetArea().CompareTo(figureArea.Key) <= 0);
    }
}