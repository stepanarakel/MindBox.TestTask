namespace MindBox.TestTask.Figures.Configuration;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public static class AppConstants
{
    public const double Accuracy = 0.0000001;

    public static class ExceptionMessages
    {
        public static class TriangleExceptionMessages
        {
            public const string LengthsOfSidesCannotBeNegative = "Длинны сторон не могут быть отрицательными.";
            public const string TriangleInequalityDoesTotHold = "По длиннам сторон невозможно построить треугольник.";
        }

        public static class CircleExceptionMessages
        {
            public const string RadiusCannotBeNegative = "Радиус не может быть отрицательным.";
        }
    }
}