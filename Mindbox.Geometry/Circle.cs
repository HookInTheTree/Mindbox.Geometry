using Mindbox.Geometry.Abstract;


namespace Mindbox.Geometry
{
    /// <summary>
    /// Сущность, представляющая собой окружность.
    /// </summary>
    public sealed class Circle : IShape
    {
        private readonly double radius;
        public double Radius => radius;

        public Circle(double _radius)
        {
            radius = _radius;
        }
        
        /// <summary>
        /// Метод для вычисления площади окружности
        /// </summary>
        /// <returns>Площадь окружности</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
