using I3SolutionsTask3;  // Assuming your Connect4 class is in this namespace

namespace I3SolutionsTask3Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void SetUp()
        {
            Connect4.Reset();  // Create a static Reset method to reset the board and currentPlayer
        }

        [Test]
        public void SampleTests()
        {
            // Test 1
            Assert.AreEqual("Player 1 has a turn", Connect4.Play(0));
            Assert.AreEqual("Player 2 has a turn", Connect4.Play(0));

            // Reset
            Connect4.Reset();

            // Test 2
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual("Player 1 has a turn", Connect4.Play(0));
                Assert.AreEqual("Player 2 has a turn", Connect4.Play(1));
            }
            Assert.AreEqual("Player 1 wins!", Connect4.Play(0));

            // Reset
            Connect4.Reset();

            // Test 3
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual("Player 1 has a turn", Connect4.Play(4));
                Assert.AreEqual("Player 2 has a turn", Connect4.Play(4));
            }
            Assert.AreEqual("Column full!", Connect4.Play(4));

            // Reset
            Connect4.Reset();

            // Test 4
            Assert.AreEqual("Player 1 has a turn", Connect4.Play(1));
            Assert.AreEqual("Player 2 has a turn", Connect4.Play(1));
            Assert.AreEqual("Player 1 has a turn", Connect4.Play(2));
            Assert.AreEqual("Player 2 has a turn", Connect4.Play(2));
            Assert.AreEqual("Player 1 has a turn", Connect4.Play(3));
            Assert.AreEqual("Player 2 has a turn", Connect4.Play(3));
            Assert.AreEqual("Player 1 wins!", Connect4.Play(4));
            Assert.AreEqual("Game has finished!", Connect4.Play(4));
        }

        [Test]
        public void Should_Start_With_Player1()
        {
            Assert.AreEqual("Player 1 has a turn", Connect4.Play(0));
        }

        [Test]
        public void Should_Switch_To_Player2()
        {
            Connect4.Play(0);
            Assert.AreEqual("Player 2 has a turn", Connect4.Play(1));
        }

        [Test]
        public void Should_Return_Column_Full()
        {
            for (int i = 0; i < 6; i++)
            {
                Connect4.Play(0);
            }
            Assert.AreEqual("Column full!", Connect4.Play(0));
        }
    }
}
