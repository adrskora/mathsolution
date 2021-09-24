using NUnit.Framework;
using MathSolution;

namespace testproj
{
    public class Tests
    {
        Math math;
        [SetUp]
        public void Setup()
        {
            math=new Math();
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(2,math.Add(1,1));
        }
    }
}