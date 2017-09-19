using System;
using Mars.Rover.Puzzle.Enums;

namespace Mars.Rover.Puzzle.Commands
{
	/// <summary>
	/// Move command class
	/// </summary>
	public class MoveCommand : ICommand
	{
		/// <summary>
		/// Execute the specified rover.
		/// </summary>
		/// <returns>The execute.</returns>
		/// <param name="rover">Rover.</param>
		public void Execute(Rover rover)
		{
			Coordinate tempCoordinate = rover.roverCoordinate;
			switch (rover.roverDirection)
			{
				case Direction.N:
					rover.roverCoordinate = rover.roverCoordinate.SetupNewCoordinates(0, 1);
					break;

				case Direction.E:
					rover.roverCoordinate = rover.roverCoordinate.SetupNewCoordinates(1, 0);
					break;

				case Direction.S:
					rover.roverCoordinate = rover.roverCoordinate.SetupNewCoordinates(0, -1);
					break;

				case Direction.W:
					rover.roverCoordinate = rover.roverCoordinate.SetupNewCoordinates(-1, 0);
					break;
			}
			// Ignore the command if rover is going out of Plateau area
			if (!RoverIsWithinLandingCoordinates(rover))
				rover.roverCoordinate = tempCoordinate;

		}

		/// <summary>
		/// Rovers the is within landing coordinates.
		/// </summary>
		/// <returns><c>true</c>, if is within landing coordinates was rovered, <c>false</c> otherwise.</returns>
		/// <param name="rover">Rover.</param>
		private bool RoverIsWithinLandingCoordinates(Rover rover)
		{
			return (rover.roverCoordinate.XCoordinate >= 0)
				&& (rover.roverCoordinate.XCoordinate <= rover.plateauArea.TopRightCoordinates.XCoordinate)
				&& (rover.roverCoordinate.YCoordinate >= 0)
				&& (rover.roverCoordinate.YCoordinate <= rover.plateauArea.TopRightCoordinates.YCoordinate);
		}
	}
}
