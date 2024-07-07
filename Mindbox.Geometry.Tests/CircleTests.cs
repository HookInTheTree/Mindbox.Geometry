

namespace Mindbox.Geometry.Tests
{
    public class CircleTests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Circle_Area_IsRight(double R)
        {
            var expectedArea = Math.PI * Math.Pow(R, 2);
            var actualArea = new Circle(R).CalculateArea();
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }
    }
}
