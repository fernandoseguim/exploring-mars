namespace ExploringMars.Models
{
	public class RigthRedirectorAgent : IMovimentAgent
    {
		public void Move(SpaceProbe spaceProbe) => spaceProbe.TurnRight();
	}
}
