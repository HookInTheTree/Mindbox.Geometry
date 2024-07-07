using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry
{
    public static class Geometry
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
