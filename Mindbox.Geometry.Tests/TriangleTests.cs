using Mindbox.Geometry.Shapes;

namespace Mindbox.Geometry.Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,2,3)]
        [TestCase(5,2,3)]
        [TestCase(6,8,1)]
        public void TriangleIsImpossible(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(13, 14, 15)]
        [TestCase(26, 28, 30)]
        [TestCase(36, 25, 29)]
        public void TriangleIsPossible(double a, double b, double c)
        {
            Assert.DoesNotThrow(() => new Triangle(a,b,c));
        }

        [TestCase(13, 14, 15, 84)]
        [TestCase(26, 28, 30, 336)]
        [TestCase(36, 25, 29, 360)]

        public void Triangle_S_IsRight(double a, double b, double c, double s)
        {
            var triangle = new Triangle(a, b, c);
            Assert.That(triangle.S, Is.EqualTo(s));
        }

        [TestCase(3,4,5)]
        [TestCase(5, 12, 13)]
        [TestCase(6, 8, 10)]

        public void Triangle_IsRight(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.That(triangle.IsRightTriangle, Is.EqualTo(true));
        }


        [TestCase(13, 14, 15)]
        [TestCase(26, 28, 30)]
        [TestCase(36, 25, 29)]

        [Test]
        public void Triangle_IsNotRight(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.That(triangle.IsRightTriangle, Is.EqualTo(false));
        }
    }
}