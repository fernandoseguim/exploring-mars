using ExploringMars.Models;
using ExploringMars.Models.Cartesians;
using Xunit;

namespace ExploringMars.Tests
{

    public class TestSpaceProbe
    {

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetDirections), MemberType = typeof(TestDataGenerator))]
        public void TestCurrentDirectionToCardinaisPoints(Direction north, Direction south, Direction east, Direction west)
        {
            Assert.Equal(north.Current, Point.North);
            Assert.Equal(south.Current, Point.South);
            Assert.Equal(east.Current, Point.East);
            Assert.Equal(west.Current, Point.West);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsToTestTurnToLeft), MemberType = typeof(TestDataGenerator))]
        public void TestTurnToLeft(SpaceProbe spaceProbe, SpaceProbe expected)
        {
            spaceProbe.TurnLeft();
            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);   
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsToTestTurnToRight), MemberType = typeof(TestDataGenerator))]
        public void TestTurnToRight(SpaceProbe spaceProbe, SpaceProbe expected)
        {
            spaceProbe.TurnRight();
            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSpaceProbeParamsToMove), MemberType = typeof(TestDataGenerator))]
        public void TestMoveToFrontInCurrentDirection(SpaceProbe spaceProbe, SpaceProbe expected)
        {
            spaceProbe.Moving();
            Assert.Equal(expected.PositionX, spaceProbe.PositionX);
            Assert.Equal(expected.PositionY, spaceProbe.PositionY);
            
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsToTurnLeftAndMove), MemberType = typeof(TestDataGenerator))]
        public void TestMoveToFrontAfterTurnLeft(SpaceProbe spaceProbe, SpaceProbe expected)
        {
            spaceProbe.TurnLeft();
            spaceProbe.Moving();

            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);
            Assert.Equal(expected.PositionX, spaceProbe.PositionX);
            Assert.Equal(expected.PositionY, spaceProbe.PositionY);

        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParamsToTurnRightAndMove), MemberType = typeof(TestDataGenerator))]
        public void TestMoveToFrontAfterTurnRight(SpaceProbe spaceProbe, SpaceProbe expected)
        {
            spaceProbe.TurnRight();
            spaceProbe.Moving();
            
            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);
            Assert.Equal(expected.PositionX, spaceProbe.PositionX);
            Assert.Equal(expected.PositionY, spaceProbe.PositionY);

        }

    }
}
