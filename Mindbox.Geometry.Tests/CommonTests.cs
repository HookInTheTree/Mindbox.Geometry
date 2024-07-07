
namespace Mindbox.Geometry.Tests
{
    public class CommonTests
    {
        [Test]
        public void CalculateAreaOfUnknownType()
        {
            Assert.DoesNotThrow(() => Geometry.CalculateArea(new Triangle(3, 4, 5)));
            Assert.DoesNotThrow(() => Geometry.CalculateArea(new Circle(5)));
        }

    }
}
