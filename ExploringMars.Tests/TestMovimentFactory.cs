using ExploringMars.Factories;
using ExploringMars.Models;
using ExploringMars.Models.Cardinals;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTestExploringMars;

namespace ExploringMars.Tests
{
    public class TestMovimentFactory
    {
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetParameterToMoviments), MemberType = typeof(TestDataGenerator))]
        public void TestCreateMoviments(string moviments, SpaceProbe spaceProbe, SpaceProbe expected)
        {
            int limitX = 5;
            int limitY = 5;
            
            SpaceProbePositioner spaceProbePositioner = new SpaceProbePositioner(limitX, limitY);
            spaceProbePositioner.MoveSpaceProbe(spaceProbe, MovimentsFactory.SetMoviments(moviments, spaceProbePositioner));
                        
            Assert.Equal(expected.PositionX, spaceProbe.PositionX);
            Assert.Equal(expected.PositionY, spaceProbe.PositionY);
            Assert.Equal(expected.Direction.Current, spaceProbe.Direction.Current);
            
        }

    }
}
