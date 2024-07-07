using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry
{
    /// <summary>
    /// Сущность, описывающая треугольник.
    /// </summary>
    public sealed class Triangle : IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        public double A => _a;
        public double B => _b;
        public double C => _c;

        public Triangle(double _a, double _b, double _c)
        {
            if (!IsValid(_a, _b, _c))
                throw new ArgumentException("Triangle is impossible because one of the sides is greater than the sum of the other two sides!");

            this._a = _a;
            this._b = _b;
            this._c = _c;
        }

        /// <summary>
        /// Метод для получения информации о том, является ли треугольник правильным. 
        /// </summary>
        /// <returns>True - правильный, False - неправильный</returns>
        public bool IsTriangleRight()
        {
            return Math.Pow(_c, 2) == Math.Pow(_a, 2) + Math.Pow(_b, 2);
        }

        /// <summary>
        /// Метод для вычисления площади треугольника
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double CalculateArea()
        {
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <summary>
        /// Метод для проверки возможности существования треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>True - треугольник может существовать, False - треугольник не может существовать</returns>
        private bool IsValid(double a, double b, double c)
        {
            return a + b > c &&
                a + c > b &&
                b + c > a;
        }

    }
}
