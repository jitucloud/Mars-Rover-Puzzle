using System;
namespace Mars.Rover.Puzzle
{
    /// <summary>
    /// Plateau class
    /// </summary>
    public class Plateau
    {
        private Coordinate _topRightCoordinates = new Coordinate(0, 0);
        private Coordinate _bottomLeftCoordinates = new Coordinate(0, 0);

        /// <summary>
        /// Gets or sets the top right coordinates.
        /// </summary>
        /// <value>The top right coordinates.</value>
        public Coordinate TopRightCoordinates
        {
            get { return _topRightCoordinates; }
            set { _topRightCoordinates = value; }
        }

        /// <summary>
        /// Gets or sets the bottom left coordinates.
        /// </summary>
        /// <value>The bottom left coordinates.</value>
		public Coordinate BottomLeftCoordinates
		{
			get { return _bottomLeftCoordinates; }
            set { _bottomLeftCoordinates = value; }
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Mars.Rover.Puzzle.Plateau"/> class.
        /// </summary>
        /// <param name="topRightXCoordinates">Top right XC oordinates.</param>
        /// <param name="topRightYCoordinates">Top right YC oordinates.</param>
		public Plateau(int topRightXCoordinates, int topRightYCoordinates)
		{
		    _topRightCoordinates =  _topRightCoordinates.SetupNewCoordinates(topRightXCoordinates,topRightYCoordinates);
		}

        /// <summary>
        /// Gets the plateau area.
        /// </summary>
        /// <returns>The plateau area.</returns>
        public String GetPlateauLandingArea()
        {
            return String.Format("Bottom left coordinate: {0}\r\nTop right coordinate: {1}"
                                            , _bottomLeftCoordinates.ToString()
                                 , _topRightCoordinates.ToString());
        }
	}
}
