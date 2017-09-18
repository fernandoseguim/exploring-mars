using ExploringMars.Models;
using ExploringMars.Models.Cardinals;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTestExploringMars;

namespace ExploringMars.Tests
{
    public class TestRedirector
    {
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSpaceProbeParamsFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void TestTurnLeft(SpaceProbe spaceProbeN, SpaceProbe spaceProbeS, SpaceProbe spaceProbeE, SpaceProbe spaceProbeW)
        {
            LeftRedirectorAgent leftRedirector = new LeftRedirectorAgent();
            leftRedirector.Move(spaceProbeN);
            leftRedirector.Move(spaceProbeS);
            leftRedirector.Move(spaceProbeE);
            leftRedirector.Move(spaceProbeW);

            Assert.Equal(Point.West, spaceProbeN.Direction.Current);
            Assert.Equal(Point.East, spaceProbeS.Direction.Current);
            Assert.Equal(Point.North, spaceProbeE.Direction.Current);
            Assert.Equal(Point.South, spaceProbeW.Direction.Current);
        }

        public void TestTurnRigth(SpaceProbe spaceProbeN, SpaceProbe spaceProbeS, SpaceProbe spaceProbeE, SpaceProbe spaceProbeW)
        {
            RigthRedirectorAgent rigthRedirector = new RigthRedirectorAgent();
            rigthRedirector.Move(spaceProbeN);
            rigthRedirector.Move(spaceProbeS);
            rigthRedirector.Move(spaceProbeE);
            rigthRedirector.Move(spaceProbeW);

            Assert.Equal(Point.East, spaceProbeN.Direction.Current);
            Assert.Equal(Point.West, spaceProbeS.Direction.Current);
            Assert.Equal(Point.South, spaceProbeE.Direction.Current);
            Assert.Equal(Point.North, spaceProbeW.Direction.Current);
        }
    }
}
