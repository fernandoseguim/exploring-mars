using ExploringMars.Models.Cartesians;

namespace ExploringMars.Models
{
	public class SpaceProbe
    {

        public Direction Direction { get; set; }
        
        public int PositionX { get; set; }
        public int PositionY { get; set; }

		public void TurnLeft() => this.Direction = this.Direction.ToLeft();

		public void TurnRight() => this.Direction = this.Direction.ToRight();

		public void Moving() {

			this.Direction.Step(this);

        }

        public override string ToString()
        {
            
            return string.Format(
                "\n{0} {1} {2}",
				this.PositionX,
				this.PositionY,
				this.Direction.Current.ToString().Substring(0,1)
                );
        }
    }
}
