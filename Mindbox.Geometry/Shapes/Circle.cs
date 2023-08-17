using Mindbox.Geometry.Abstract;


namespace Mindbox.Geometry.Shapes
{
    public sealed class Circle : Shape
    {
        private readonly double radius;
        private readonly double s;
        public Circle(double _radius)
        {
            radius = _radius;

            s = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
        public override double S => s;
    }
}
