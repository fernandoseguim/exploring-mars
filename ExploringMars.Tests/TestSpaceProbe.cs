using ExploringMars.Models;
using ExploringMars.Models.Cardinals;
using Xunit;

namespace XUnitTestExploringMars
{

    public class TestSpaceProbe
    {

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetDirectionsFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void TestCurrentDirectionToCardinaisPoints(Direction north, Direction south, Direction east, Direction west)
        {
            Assert.Equal(north.Current, Point.North);
            Assert.Equal(south.Current, Point.South);
            Assert.Equal(east.Current, Point.East);
            Assert.Equal(west.Current, Point.West);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSpaceProbeParamsFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void TestTurnToLeft(SpaceProbe spaceProbeN, SpaceProbe spaceProbeS, SpaceProbe spaceProbeE, SpaceProbe spaceProbeW)
        {
            
            spaceProbeN.TurnLeft();
            spaceProbeS.TurnLeft();
            spaceProbeE.TurnLeft();
            spaceProbeW.TurnLeft();

            Assert.Equal(Point.West, spaceProbeN.Direction.Current);
            Assert.Equal(Point.East, spaceProbeS.Direction.Current);
            Assert.Equal(Point.North, spaceProbeE.Direction.Current);
            Assert.Equal(Point.South, spaceProbeW.Direction.Current);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSpaceProbeParamsFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void TestTurnToRight(SpaceProbe spaceProbeN, SpaceProbe spaceProbeS, SpaceProbe spaceProbeE, SpaceProbe spaceProbeW)
        {

            spaceProbeN.TurnRight();
            spaceProbeS.TurnRight();
            spaceProbeE.TurnRight();
            spaceProbeW.TurnRight();

            Assert.Equal(Point.East, spaceProbeN.Direction.Current);
            Assert.Equal(Point.West, spaceProbeS.Direction.Current);
            Assert.Equal(Point.South, spaceProbeE.Direction.Current);
            Assert.Equal(Point.North, spaceProbeW.Direction.Current);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSpaceProbeParamsFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void TestMoveToFrontInCurrentDirection(SpaceProbe spaceProbeN, SpaceProbe spaceProbeS, SpaceProbe spaceProbeE, SpaceProbe spaceProbeW)
        {

            spaceProbeN.Moving();
            spaceProbeS.Moving();
            spaceProbeE.Moving();
            spaceProbeW.Moving();

            Assert.Equal(1, spaceProbeN.PositionY);
            Assert.Equal(1, spaceProbeS.PositionY);
            Assert.Equal(1, spaceProbeE.PositionX);
            Assert.Equal(1, spaceProbeW.PositionX);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSpaceProbeParamsFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void TestMoveToFrontAfterTurnLeft(SpaceProbe spaceProbeN, SpaceProbe spaceProbeS, SpaceProbe spaceProbeE, SpaceProbe spaceProbeW)
        {
            spaceProbeN.TurnLeft();
            spaceProbeS.TurnLeft();
            spaceProbeE.TurnLeft();
            spaceProbeW.TurnLeft();

            spaceProbeN.Moving();
            spaceProbeS.Moving();
            spaceProbeE.Moving();
            spaceProbeW.Moving();

            Assert.Equal(1, spaceProbeN.PositionX);
            Assert.Equal(1, spaceProbeS.PositionX);
            Assert.Equal(1, spaceProbeE.PositionY);
            Assert.Equal(1, spaceProbeW.PositionY);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSpaceProbeParamsFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void TestMoveToFrontAfterTurnRight(SpaceProbe spaceProbeN, SpaceProbe spaceProbeS, SpaceProbe spaceProbeE, SpaceProbe spaceProbeW)
        {
            spaceProbeN.TurnRight();
            spaceProbeS.TurnRight();
            spaceProbeE.TurnRight();
            spaceProbeW.TurnRight();

            spaceProbeN.Moving();
            spaceProbeS.Moving();
            spaceProbeE.Moving();
            spaceProbeW.Moving();

            Assert.Equal(1, spaceProbeN.PositionX);
            Assert.Equal(1, spaceProbeS.PositionX);
            Assert.Equal(1, spaceProbeE.PositionY);
            Assert.Equal(1, spaceProbeW.PositionY);
        }

    }
}
