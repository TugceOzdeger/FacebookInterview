using FacebookInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IslandPerimeterTest
{
    [TestClass]
    public class IslandPerimeterTest
    {
        [TestMethod]
        public void Test_IslandPerimeter()
        {
            var islandPerimeter = new IslandPerimeter();
            var perimeter = islandPerimeter.FindIslandPerimeter();
            Assert.AreEqual(perimeter, 16);
        }
    }
}
