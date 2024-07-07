namespace Mindbox.Geometry.Abstract
{
    /// <summary>
    /// Контракт объекта, который может представлять собой геометрическую фигуру
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Метод для вычисления площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double CalculateArea();
    }
}
