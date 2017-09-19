using System;
namespace Mars.Rover.Puzzle.Commands
{
	/// <summary>
	/// Command Interface
	/// </summary>
	public interface ICommand
	{
		/// <summary>
		/// Execute the specified rover.
		/// </summary>
		/// <returns>The execute.</returns>
		/// <param name="rover">Rover.</param>
		void Execute(Rover rover);
	}
}
