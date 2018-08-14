using ExploringMars.Factories;
using ExploringMars.Models;
using Xunit;

namespace ExploringMars.Tests
{
    public class TestMovimentFactory
    {
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParameterToMoviments), MemberType = typeof(TestDataGenerator))]
        public void TestCreateMoviments(string moviments, SpaceProbe spaceProbe, SpaceProbe expected)
        {
            var limitX = 5;
            var limitY = 5;
            
            var spaceProbePositioner = new SpaceProbePositioner(limitX, limitY);
            spaceProbePositioner.MoveSpaceProbe(spaceProbe, MovimentsFactory.SetMoviments(moviments, spaceProbePositioner));
                        
            Assert.Equal(expected.PositionX, spaceProbe.PositionX);
            Assert.Equal(expected.PositionY, spaceProbe.PositionY);
            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);
            
        }

    }
}
