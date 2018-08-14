using ExploringMars.Factories;
using ExploringMars.Helpers;
using ExploringMars.Models;
using System;

namespace ExploringMars.App
{
	class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var limitX = InputParams.Position("Set limit to cartesian point from X axis: ");
                var limitY = InputParams.Position("Set limit to cartesian point from Y axis: ");

                var spaceProbePositioner = new SpaceProbePositioner(limitX, limitY);

                while (true)
                {
                    var positionX = InputParams.Position("Set cartesian point from X axis: ");
                    var positionY = InputParams.Position("Set cartesian point from Y axis: ");
                    var direction = InputParams.Direction("Set direction in plateau (N S E W): ");
                    var moviments = InputParams.Moviments("Set sequence of moviments. Ex: L M L M L M L M M: ");
                    var spaceProbe = new SpaceProbe()
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
			Console.ReadKey();
		}
    }
}
