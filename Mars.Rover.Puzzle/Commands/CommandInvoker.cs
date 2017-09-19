using System;
using Mars.Rover.Puzzle.Enums;

namespace Mars.Rover.Puzzle.Commands
{
	/// <summary>
	/// Command invoker.
	/// </summary>
	public static class CommandInvoker
	{
		/// <summary>
		/// Gets the command.
		/// </summary>
		/// <returns>The command.</returns>
		/// <param name="action">Action.</param>
		public static ICommand GetCommand(string action)
		{
			Command actionEnum;

			if (Enum.TryParse(action, out actionEnum))
			{
				switch (actionEnum)
				{
					case Command.L:
						return new TurnLeftCommand();
					case Command.R:
						return new TurnRightCommand();
					case Command.M:
						return new MoveCommand();
					default:
						return new MoveCommand();
				}
			}
			else
			{
				throw new Exception("entered command is not correct");
			}

		}
	}
}
