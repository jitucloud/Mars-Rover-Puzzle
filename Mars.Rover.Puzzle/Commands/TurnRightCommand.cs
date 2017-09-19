using System;
using Mars.Rover.Puzzle.Enums;

namespace Mars.Rover.Puzzle.Commands
{
	/// <summary>
	/// Turn right command.
	/// </summary>
	public class TurnRightCommand : ICommand
	{
		/// <summary>
		/// Execute the specified rover.
		/// </summary>
		/// <returns>The execute.</returns>
		/// <param name="rover">Rover.</param>
		public void Execute(Rover rover)
		{
			switch (rover.roverDirection)
			{
				case Direction.N:
					rover.roverDirection = Direction.E;
					break;

				case Direction.W:
					rover.roverDirection = Direction.N;
					break;

				case Direction.S:
					rover.roverDirection = Direction.W;
					break;

				case Direction.E:
					rover.roverDirection = Direction.S;
					break;
			}

		}
	}
}
