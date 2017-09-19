using System;
namespace Mars.Rover.Puzzle
{
    public class State
    {
		public Direction Direction;

		public Coordinate Coordinate;

		public State(Direction direction, Coordinate coordinate)
		{
			Direction = direction;
			Coordinate = coordinate;
		}
	}
}
