using ExploringMars.Models;
using Xunit;

namespace ExploringMars.Tests
{
	public class TestRedirector
    {
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsToTestTurnToLeft), MemberType = typeof(TestDataGenerator))]
        public void TestTurnLeftWithRedirector(SpaceProbe spaceProbe, SpaceProbe expected)
        {
            var leftRedirector = new LeftRedirectorAgent();
            leftRedirector.Move(spaceProbe);            
            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsToTestTurnToRight), MemberType = typeof(TestDataGenerator))]
        public void TestTurnRigthWithRedirector(SpaceProbe spaceProbe, SpaceProbe expected)
        {
            var rigthRedirector = new RigthRedirectorAgent();
            rigthRedirector.Move(spaceProbe);
            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);
        }
    }
}
