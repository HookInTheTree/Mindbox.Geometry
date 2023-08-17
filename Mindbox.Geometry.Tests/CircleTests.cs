using Mindbox.Geometry.Shapes;


namespace Mindbox.Geometry.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void Circle_S_IsRight(double R)
        {
            var expectedArea = Math.PI * Math.Pow(R, 2);
            var actualArea = new Circle(R).Area;
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }
    }
}
