using I3SolutionsTask2;

namespace I3SolutionsTask2Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SimpleTests()
        {
            Assert.AreEqual(1, FindOutliner.FindOutlinerMethod(new int[] { 0, 1, 2 }));
            Assert.AreEqual(2, FindOutliner.FindOutlinerMethod(new int[] { 1, 2, 3 }));
            Assert.AreEqual(3, FindOutliner.FindOutlinerMethod(new int[] { 2, 6, 8, 10, 3 }));
            Assert.AreEqual(3, FindOutliner.FindOutlinerMethod(new int[] { 0, 0, 3, 0, 0 }));
            Assert.AreEqual(0, FindOutliner.FindOutlinerMethod(new int[] { 1, 1, 0, 1, 1 }));
        }
    }
}