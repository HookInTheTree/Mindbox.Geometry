using Mindbox.Geometry.Abstract;


namespace Mindbox.Geometry.Shapes
{
    public sealed class Triangle : Shape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        private readonly double s;
        private readonly bool isRight;

        public Triangle(double _a, double _b, double _c)
        {
            if (!IsValid(_a, _b, _c))
                throw new ArgumentException("Triangle is impossible because one of the sides is greater than the sum of the other two sides!");

            a = _a;
            b = _b;
            c = _c;

            var p = (a + b + c) / 2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            s = S;

            isRight = Math.Pow(c, 2) == Math.Pow(a,2) + Math.Pow(b,2);
        }

        public double A => a;
        public double B => b;
        public double C => c;
        public override double S => s;
        public bool IsRightTriangle => isRight;

        private bool IsValid(double a, double b, double c)
        {
            return a + b > c &&
                a + c > b &&
                b + c > a;
        }

    }
}
