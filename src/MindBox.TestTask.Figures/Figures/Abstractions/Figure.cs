using MindBox.TestTask.Figures.Interfaces;

namespace MindBox.TestTask.Figures.Figures.Abstractions;

/// <summary>
/// Фигура.
/// </summary>
public abstract class Figure : IFigureArea
{
    /// <inheritdoc />
    public abstract double GetArea();
}