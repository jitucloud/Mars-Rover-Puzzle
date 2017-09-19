using System;
using Mars.Rover.Puzzle.Enums;

namespace Mars.Rover.Puzzle.Commands
{
	/// <summary>
	/// Turn left command.
	/// </summary>
	public class TurnLeftCommand : ICommand
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
					rover.roverDirection = Direction.W;
					break;

				case Direction.W:
					rover.roverDirection = Direction.S;
					break;

				case Direction.S:
					rover.roverDirection = Direction.E;
					break;

				case Direction.E:
					rover.roverDirection = Direction.N;
					break;
			}
		}
	}
}
