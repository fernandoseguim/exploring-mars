﻿using ExploringMars.Model;
using ExploringMars.Model.Cardinals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestExploringMars
{
    
    public class TestDataGenerator : IEnumerable<object[]>
    {
        
        public static IEnumerable<object[]> GetDirectionsFromDataGenerator()
        {
            yield return new object[]
            {
                new North { },
                new South { },
                new East { },
                new West { }
            };
            
        }

        public static IEnumerable<object[]> GetSpaceProbeParamsFromDataGenerator()
        {
            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 0,
                    PositionY = 0
                },

                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 0,
                    PositionY = 0
                },

                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 0,
                    PositionY = 0
                },

                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

        }

        public static IEnumerable<object[]> GetParamsMoveToNorth()
        {
            yield return new object[]  { 2, 5, new North { } };
        }

        public static IEnumerable<object[]> GetParamsMoveToEast()
        {
            yield return new object[] { 2, 5, new East { } };
        }

        public static IEnumerable<object[]> GetParamsMoveEast()
        {
            yield return new object[] { 10, 8, new East { } };
        }

        public static IEnumerable<object[]> GetParamsMoveToWest()
        {
            yield return new object[] { 0, 8, new West { } };
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
