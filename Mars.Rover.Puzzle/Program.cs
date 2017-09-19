using System;
using Mars.Rover.Puzzle.Enums;

namespace Mars.Rover.Puzzle
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Set up Plateau Area : " + "5 5");

            // Setup initial plateau area
            Plateau plateau = new Plateau(5, 5);

            Console.WriteLine(plateau.GetPlateauLandingArea());

            Console.WriteLine("**********************************************************");

            // Set Initial Rover Position
            Rover rover1 = new Rover(new Coordinate(1, 2), Direction.N, plateau);

            Console.WriteLine(String.Format("{0} : {1}", "Initial Position of rover", rover1.RoverCurrentPosition()));

            Console.WriteLine("Enter command for rover : " + "LMLMLMLMM");

            rover1.Run("LMLMLMLMM");

            Console.WriteLine(String.Format("{0} : {1}", "Final Position of rover", rover1.RoverCurrentPosition()));


            Console.WriteLine("**********************************************************");


            // Set Initial Rover Position
            Rover rover2 = new Rover(new Coordinate(3, 3), Direction.E, plateau);

            Console.WriteLine(String.Format("{0} : {1}", "Initial Position of rover", rover2.RoverCurrentPosition()));

            Console.WriteLine("Enter command for rover : " + "MMRMMRMRRM");

            rover2.Run("MMRMMRMRRM");

            Console.WriteLine(String.Format("{0} : {1}", "Final Position of rover", rover2.RoverCurrentPosition()));


        }
    }
}
