using I3SolutionsTask1;

namespace I3SolutionsTask1Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestIsValidWalk()
        {
            Assert.AreEqual(true, Walkinginthecity.IsValidWalk(new char[] { 'n', 's', 'n', 's', 'n', 's', 'n', 's', 'n', 's' }));
            Assert.AreEqual(false, Walkinginthecity.IsValidWalk(new char[] { 'w', 'e', 'w', 'e', 'w', 'e', 'w', 'e', 'w', 'e', 'w', 'e' }));
            Assert.AreEqual(false, Walkinginthecity.IsValidWalk(new char[] { 'w' }));
            Assert.AreEqual(false, Walkinginthecity.IsValidWalk(new char[] { 'n', 'n', 'n', 's', 'n', 's', 'n', 's', 'n', 's' }));
        }
    }
}