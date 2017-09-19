using System;
using System.Linq;

namespace Mars.Rover.Puzzle.Helper
{

    /// <summary>
    /// Command parser.
    /// </summary>
    public static class CommandParser
    {
        /// <summary>
        /// Gets the individual commands.
        /// </summary>
        /// <returns>The individual commands.</returns>
        /// <param name="commandString">Command string.</param>
        public static string[] GetIndividualCommands(String commandString)
        {
            return commandString.ToCharArray().Select(c => c.ToString()).ToArray();
        }
         
    }
}
