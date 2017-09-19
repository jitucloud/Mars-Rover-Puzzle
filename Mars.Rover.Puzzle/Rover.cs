using System;
using System.Linq;
using Mars.Rover.Puzzle.Commands;
using Mars.Rover.Puzzle.Enums;
using Mars.Rover.Puzzle.Helper;

namespace Mars.Rover.Puzzle
{
    /// <summary>
    /// Rover class
    /// </summary>
    public class Rover
    {
        public Coordinate roverCoordinate;
        public Direction roverDirection;
        public Plateau plateauArea;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Mars.Rover.Puzzle.Rover"/> class.
        /// </summary>
        /// <param name="coordinate">Coordinate.</param>
        /// <param name="direction">Direction.</param>
        /// <param name="plateau">Plateau.</param>
        public Rover(Coordinate coordinate, Direction direction, Plateau plateau)
        {
            
            roverCoordinate = coordinate;
            roverDirection = direction;
            plateauArea = plateau;

        }

        /// <summary>
        /// Rovers the current position.
        /// </summary>
        /// <returns>The current position.</returns>
        public String RoverCurrentPosition()
        {
            return String.Format("{0} {1}", roverCoordinate.ToString(), roverDirection.ToString());
        }

        /// <summary>
        /// Run the specified commandString.
        /// </summary>
        /// <returns>The run.</returns>
        /// <param name="commandString">Command string.</param>
        public void Run(String commandString)
        {
            foreach (String command in CommandParser.GetIndividualCommands(commandString))
            {
                ICommand roverReady = CommandInvoker.GetCommand(command);
                roverReady.Execute(this);
            }
        }

    }
}
