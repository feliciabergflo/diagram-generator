using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiagramGenerator
{
    /// <summary>
    /// Responsible for storing and managing data related to the diagram.
    /// </summary>
    public class DiagramData
    {
        #region FIELDS
        private List<PointF> points;
        private int xIntervals;
        private int yIntervals;
        private int xIntervalValue;
        private int yIntervalValue;
        #endregion

        #region PROPERTIES
        public List<PointF> Points
        {
            get { return points; }
        }

        public int XIntervals
        {
            get { return xIntervals; }
            set { xIntervals = value; }
        }

        public int YIntervals
        {
            get { return yIntervals; }
            set { yIntervals = value; }
        }

        public int XIntervalValue
        {
            get { return xIntervalValue; }
            set { xIntervalValue = value; }
        }

        public int YIntervalValue
        {
            get { return yIntervalValue; }
            set { yIntervalValue = value; }
        }
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the DiagramData class, 
        /// and creates a new empty list of points.
        /// </summary>
        public DiagramData()
        {
            points = new List<PointF>();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Adds a new point to the list of points.
        /// </summary>
        /// <param name="x">X coordinate in float.</param>
        /// <param name="y">Y coordinate in float.</param>
        public void AddPoint(float x, float y)
        {
            points.Add(new PointF(x, y));
        }

        /// <summary>
        /// Validates that x and y are positive and within the limits of the diagram.
        /// </summary>
        /// <param name="x">X coordinate in float.</param>
        /// <param name="y">Y coordinate in float.</param>
        public void ValidateData(float x, float y)
        {
            // Check if x and y are positive numbers
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Coordinates must be positive numbers.");
            }

            // Check if x and y are within the limits of the diagram
            if (x < 0 || x > (xIntervals * xIntervalValue) ||
                y < 0 || y > (yIntervals * yIntervalValue))
            {
                throw new ArgumentException("Coordinates are outside the limits of the diagram.");
            }
        }

        /// <summary>
        /// Sorts the data depending on either their x- or y-value.
        /// </summary>
        /// <param name="coordinate">Either "x" or "y".</param>
        public void SortData(string coordinate)
        {
            if (coordinate == "x")
            {
                // Sorts points depending on their x-value
                Points.Sort((p1, p2) => p1.X.CompareTo(p2.X));
            } 
            else
            {
                // Sorts points depending on their y-value
                Points.Sort((p1, p2) => p1.Y.CompareTo(p2.Y));
            }
        }

        /// <summary>
        /// Clears all data stored in the class.
        /// </summary>
        public void Clear()
        {
            points.Clear();
        }
        #endregion
    }
}
