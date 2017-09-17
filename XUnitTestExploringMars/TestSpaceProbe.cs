using ExploringMars.Model;
using System;
using Xunit;

namespace XUnitTestExploringMars
{
    public class TestSpaceProbe
    {
        [Theory]
        [InlineData(CardinalPoints.North, CardinalPoints.West)]
        [InlineData(CardinalPoints.South, CardinalPoints.East)]
        [InlineData(CardinalPoints.East, CardinalPoints.North)]
        [InlineData(CardinalPoints.West, CardinalPoints.South)]
        public void TestTurnToLeftOfCurrentPosition(CardinalPoints direction, CardinalPoints left )
        {
            SpaceProbe spaceProbe = new SpaceProbe
            {
                Direction = direction,
                PositionX = 0,
                PositionY = 0
            };
            spaceProbe.TurnLeft();

            Assert.Equal(left, spaceProbe.Direction);

        }

        [Theory]
        [InlineData(CardinalPoints.North, CardinalPoints.East)]
        [InlineData(CardinalPoints.South, CardinalPoints.West)]
        [InlineData(CardinalPoints.East, CardinalPoints.South)]
        [InlineData(CardinalPoints.West, CardinalPoints.North)]
        public void TestTurnToRigthOfCurrentPosition(CardinalPoints direction, CardinalPoints right)
        {
            SpaceProbe spaceProbe = new SpaceProbe
            {
                Direction = direction,
                PositionX = 0,
                PositionY = 0
            };

            spaceProbe.TurnRight();
            Assert.Equal(right, spaceProbe.Direction);
        }

        [Theory]
        [InlineData(0,0,1)]
        [InlineData(1, 2, 2)]
        public void TestMoveToFrontWhenTurnToEastOrWest(int positionX, int positionY, int positionN)
        {
            SpaceProbe spaceProbeEast = new SpaceProbe
            {
                Direction = CardinalPoints.East,
                PositionX = positionX,
                PositionY = positionY
            };

            SpaceProbe spaceProbeWest = new SpaceProbe
            {
                Direction = CardinalPoints.West,
                PositionX = positionX,
                PositionY = positionY
            };

            spaceProbeEast.Moving();
            spaceProbeWest.Moving();

            Assert.Equal(positionN, spaceProbeEast.PositionX);
            Assert.Equal(positionN, spaceProbeWest.PositionX);
        }

        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(1, 2, 3)]
        public void TestMoveToFrontWhenTurnToNorthOrSouth(int positionX, int positionY, int positionN)
        {
            SpaceProbe spaceProbeEast = new SpaceProbe
            {
                Direction = CardinalPoints.North,
                PositionX = positionX,
                PositionY = positionY
            };

            SpaceProbe spaceProbeWest = new SpaceProbe
            {
                Direction = CardinalPoints.South,
                PositionX = positionX,
                PositionY = positionY
            };

            spaceProbeEast.Moving();
            spaceProbeWest.Moving();

            Assert.Equal(positionN, spaceProbeEast.PositionY);
            Assert.Equal(positionN, spaceProbeWest.PositionY);
        }

    }
}
