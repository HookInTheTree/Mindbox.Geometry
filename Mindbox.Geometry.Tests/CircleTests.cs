using Mindbox.Geometry.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Geometry.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 3.14)]
        [TestCase(2, 12.56)]
        [TestCase(5, 50.26)]
        public void Circle_S_IsRight(double R, double S)
        {
            Assert.AreEqual(S, new Circle(R).S);
        }
    }
}
