using ExploringMars.Models;
using ExploringMars.Models.Cartesians;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ExploringMars.Tests
{

    public class TestDataGenerator : IEnumerable<object[]>
    {
        
        public static IEnumerable<object[]> GetDirections()
        {
            yield return new object[]
            {
                new North { },
                new South { },
                new East { },
                new West { }
            };
            
        }

        public static IEnumerable<object[]> GetParamsToTestTurnToLeft()
        {
            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 0,
                    PositionY = 0
                }
                
            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

        }

        public static IEnumerable<object[]> GetParamsToTestTurnToRight()
        {
            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 0,
                    PositionY = 0
                },
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 0,
                    PositionY = 0
                }

            };

        }

        public static IEnumerable<object[]> GetSpaceProbeParamsToMove()
        {
            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 5,
                    PositionY = 6
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 5,
                    PositionY = 4
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 6,
                    PositionY = 5
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 4,
                    PositionY = 5
                }

            };

        }

        public static IEnumerable<object[]> GetParamsToTurnLeftAndMove()
        {
            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 4,
                    PositionY = 5
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 6,
                    PositionY = 5
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 5,
                    PositionY = 6
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 5,
                    PositionY = 4
                }

            };

        }

        public static IEnumerable<object[]> GetParamsToTurnRightAndMove()
        {
            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 6,
                    PositionY = 5
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 4,
                    PositionY = 5
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new East { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new South { },
                    PositionX = 5,
                    PositionY = 4
                }

            };

            yield return new object[]
            {
                new SpaceProbe {
                    Direction = new West { },
                    PositionX = 5,
                    PositionY = 5
                },
                new SpaceProbe {
                    Direction = new North { },
                    PositionX = 5,
                    PositionY = 6
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
        
        public static IEnumerable<object[]> GetParamsMoveToWest()
        {
            yield return new object[] { 0, 8, new West { } };
        }
        
        public static IEnumerable<object[]> GetParameterToMoviments()
        {

            yield return new object[]
            {
                "LMLMLMLMM",
                new SpaceProbe
                {
                    Direction = new North { },
                    PositionX = 1,
                    PositionY = 2
                },
                new SpaceProbe
                {
                    Direction = new North { },
                    PositionX = 1,
                    PositionY = 3
                }
            };

            yield return new object[]
            {
                "MMRMMRMRRM",
                new SpaceProbe
                {
                    Direction = new East { },
                    PositionX = 3,
                    PositionY = 3
                },
                new SpaceProbe
                {
                    Direction = new East { },
                    PositionX = 5,
                    PositionY = 1
                }
            };

        }

		public IEnumerator<object[]> GetEnumerator() => throw new NotImplementedException();

		IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
	}
}
