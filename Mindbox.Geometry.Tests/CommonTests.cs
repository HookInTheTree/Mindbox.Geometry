using Mindbox.Geometry.Abstract;
using Mindbox.Geometry.Shapes;

namespace Mindbox.Geometry.Tests
{
    public class CommonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateAreaOfUnknownType()
        {
            Assert.DoesNotThrow(() => Calculate(new Triangle(3, 4, 5)));
            Assert.DoesNotThrow(() => Calculate(new Circle(5)));
        }

        private void Calculate(Shape shape)
        {
            var s = shape.Area;
        }
    }
}
