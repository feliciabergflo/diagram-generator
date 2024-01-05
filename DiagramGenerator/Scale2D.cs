using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramGenerator
{
    /// <summary>
    /// Represents a scaling mechanism to calculate the appropriate scale and dimensions
    /// for a figure within a given component, considering a specified margin percentage.
    /// </summary>
    public class DrawingScale
    {
        #region FIELDS
        // Measurements of the figure
        private double width, height;

        // Measurements of the component
        private double boxWidth, boxHeight;

        // Percentage of the width/height to be left as margin (spacing around figure)
        private double marginPercent;

        // The actual margin size based on margin percentage and figure's dimensions
        private double margin;

        // Scaling factors applied to the figure
        private double scale, scaleX, scaleY;
        
        // Modified scaling factors that consider the margin (scale - scaled margin)
        private double scaleMargin, scaleXMargin, scaleYMargin;

        // Scaled measurements of the figure's width and height, considering the margin
        private double scaleWidth, scaleHeight;
        #endregion

        #region PROPERTIES
        public double Scale
        {
            get { return scale; }
        }

        public double Margin
        {
            get { return margin; }
        }

        public double ScaleXMargin
        {
            get { return scaleXMargin; }
        }

        public double ScaleYMargin
        {
            get { return scaleYMargin; }
        }

        public double ScaleWidth
        {
            get { return scaleWidth; }
        }

        public double ScaleHeight
        {
            get { return scaleHeight; }
        }
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the DrawingScale class.
        /// </summary>
        /// <param name="ctrlWidth">Width of the component in pixels.</param>
        /// <param name="ctrlHeight">Height of the component in pixels.</param>
        /// <param name="width">Max width of the figure.</param>
        /// <param name="height">Max height of the figure.</param>
        /// <param name="marginPercent">Percent of the width/height to be left as margin.</param>
        public DrawingScale(double ctrlWidth, double ctrlHeight, double width, double height, double marginPercent)
        {
            this.width = width;
            this.height = height;
            this.boxWidth = ctrlWidth;
            this.boxHeight = ctrlHeight;
            this.marginPercent = marginPercent;

            CalcScales();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Calculates the scale using the given indata.
        /// </summary>
        private void CalcScales()
        {
            margin = Math.Min(marginPercent * boxWidth, marginPercent * boxHeight);

            scaleHeight = boxHeight - margin * 2.0;
            scaleWidth = boxWidth - margin * 2.0;

            scaleX = boxWidth / width;
            scaleY = boxHeight / height;

            scaleXMargin = scaleWidth / width;
            scaleYMargin = scaleHeight / height;

            scale = Math.Abs(Math.Min(scaleX, scaleY));
            scaleMargin = Math.Abs(Math.Min(scaleXMargin, scaleYMargin));
        }
        #endregion
    }
}
