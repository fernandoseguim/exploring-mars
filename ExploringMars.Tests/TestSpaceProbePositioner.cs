using ExploringMars.Exceptions;
using ExploringMars.Models;
using ExploringMars.Models.Cartesians;
using Xunit;

namespace ExploringMars.Tests
{
    public class TestSpaceProbePositioner
    {

        public void PrepareTest(int limitX, int limitY, Direction direction)
        {
            SpaceProbePositioner spaceProbePositioner = new SpaceProbePositioner(limitX, limitY);
            SpaceProbe spaceProbe = new SpaceProbe()
            {
                Direction = direction,
                PositionX = limitX,
                PositionY = limitY

            };
            MovimentAgent motionAgent = new MovimentAgent(spaceProbePositioner);
            spaceProbePositioner.MoveSpaceProbe(spaceProbe, motionAgent);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsMoveToNorth), MemberType = typeof(TestDataGenerator))]
        public void TestThrowsSpaceProbePositionOutOfPlateauExceptionWhenMoveToNorth(int limitX, int limitY, Direction direction)
        {
            Assert.Throws<SpaceProbePositionOutOfPlateauException>(() => PrepareTest(limitX, limitY, direction));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsMoveToEast), MemberType = typeof(TestDataGenerator))]
        public void TestThrowsSpaceProbePositionOutOfPlateauExceptionWhenTurnToSouth(int limitX, int limitY, Direction direction)
        {
            Assert.Throws<SpaceProbePositionOutOfPlateauException>(() => PrepareTest(limitX, limitY, direction));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsMoveToEast), MemberType = typeof(TestDataGenerator))]
        public void TestThrowsSpaceProbePositionOutOfPlateauExceptionWhenMoveToEast(int limitX, int limitY, Direction direction)
        {
            Assert.Throws<SpaceProbePositionOutOfPlateauException>(() => PrepareTest(limitX, limitY, direction));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsMoveToWest), MemberType = typeof(TestDataGenerator))]
        public void TestThrowsSpaceProbePositionOutOfPlateauExceptionWhenMoveToWest(int limitX, int limitY, Direction direction)
        {
            Assert.Throws<SpaceProbePositionOutOfPlateauException>(() => PrepareTest(limitX, limitY, direction));
        }

    }
}
