using MindBox.TestTask.Figures.Figures;
using static MindBox.TestTask.Figures.Configuration.AppConstants.ExceptionMessages.CircleExceptionMessages;

namespace MindBox.TestTask.Tests;

/// <summary>
/// Тест круга.
/// </summary>
public class CircleTest
{
    /// <summary>
    /// Проверить ограничение отрицательной длинны радиуса.
    /// </summary>
    [Fact(DisplayName = "Проверить ограничение отрицательной длинны радиуса.")]
    public void CheckLimitOfNegativeRadiusLength()
    {
        var action = () => new Circle(-1);
        var exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal(RadiusCannotBeNegative, exception.Message);
    }
}