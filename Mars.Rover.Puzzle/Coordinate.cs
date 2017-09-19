using System;
using System.Text;

namespace Mars.Rover.Puzzle
{
    /// <summary>
    /// Coordinate class
    /// </summary>
    public class Coordinate
    {
        private int _xCoordinate;
        private int _yCoordinate;

        /// <summary>
        /// Gets or sets the XCoordinate.
        /// </summary>
        /// <value>The XCoordinate.</value>
        public int XCoordinate
        {
            get
            { 
                return _xCoordinate; 
            }
            set
            {
                if (value < 0)
                    throw new Exception("x-coordinate cannot be less than zero");
                 else
                _xCoordinate = value;
            }
        }

        /// <summary>
        /// Gets or sets the YCoordinate.
        /// </summary>
        /// <value>The YCoordinate.</value>
		public int YCoordinate
		{
			get 
            { 
                return _yCoordinate; 
            }
			set
            {
				if (value < 0)
					throw new Exception("y-coordinate cannot be less than zero");
				else
					_yCoordinate = value;
            }
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Mars.Rover.Puzzle.Coordinate"/> class.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
		public Coordinate(int x, int y)
		{
			_xCoordinate = x;
			_yCoordinate = y;
		}

        /// <summary>
        /// Setups the new coordinates.
        /// </summary>
        /// <returns>The new coordinates.</returns>
        /// <param name="xSetupCoordinate">X setup coordinate.</param>
        /// <param name="ySetupCoordinate">Y setup coordinate.</param>
		public Coordinate SetupNewCoordinates(int xSetupCoordinate, int ySetupCoordinate)
		{
		    return new Coordinate(_xCoordinate + xSetupCoordinate, _yCoordinate + ySetupCoordinate);
		}

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:Mars.Rover.Puzzle.Coordinate"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:Mars.Rover.Puzzle.Coordinate"/>.</returns>
        public override string ToString()
		{
            return string.Format("{0} {1}",_xCoordinate,_yCoordinate);
		}
    }
}