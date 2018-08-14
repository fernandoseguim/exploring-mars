namespace ExploringMars.Models
{
	public class LeftRedirectorAgent : IMovimentAgent
    {
		public void Move(SpaceProbe spaceProbe) => spaceProbe.TurnLeft();

	}
}
