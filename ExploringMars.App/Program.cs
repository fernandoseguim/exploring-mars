using ExploringMars.Factories;
using ExploringMars.Helpers;
using ExploringMars.Models;
using ExploringMars.Models.Cartesians;
using System;

namespace ExploringMars.App
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int limitX = InputParams.Position("Set limit to cartesian point from X axis: ");
                int limitY = InputParams.Position("Set limit to cartesian point from Y axis: ");

                SpaceProbePositioner spaceProbePositioner = new SpaceProbePositioner(limitX, limitY);

                while (true)
                {
                    int positionX = InputParams.Position("Set cartesian point from X axis: ");
                    int positionY = InputParams.Position("Set cartesian point from Y axis: ");
                    Direction direction = InputParams.Direction("Set direction in plateau (N S E W): ");
                    string moviments = InputParams.Moviments("Set sequence of moviments. Ex: L M L M L M L M M: ");
                    SpaceProbe spaceProbe = new SpaceProbe()
                    {
                        Direction = direction,
                        PositionX = positionX,
                        PositionY = positionY
                    };

                    spaceProbePositioner.MoveSpaceProbe(spaceProbe, MovimentsFactory.SetMoviments(moviments, spaceProbePositioner));
                    Console.WriteLine(spaceProbe.ToString());
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
