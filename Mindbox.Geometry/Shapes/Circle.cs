using Mindbox.Geometry.Abstract;


namespace Mindbox.Geometry.Shapes
{
    public sealed class Circle : Shape
    {
        private readonly double radius;
        private readonly double area;
        public Circle(double _radius)
        {
            radius = _radius;

            area = Math.PI * Math.Pow(radius, 2);
        }
        public override double Area => area;
        public double Radius => radius;
    }
}
