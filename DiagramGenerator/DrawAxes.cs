using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramGenerator
{
    /// <summary>
    /// Responsible for drawing the axes of a diagram on the panel. 
    /// </summary>
    public class DrawAxes
    {
        #region FIELDS
        private Graphics graphics;
        private Panel panel;
        private int xInterval;
        private int yInterval;
        private int xIntervalValue;
        private int yIntervalValue;
        private DrawingScale scale;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the DrawAxes class.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="panel">The panel where the diagram is drawn.</param>
        /// <param name="xInterval">The number of intervals on the X-axis.</param>
        /// <param name="yInterval">The number of intervals on the Y-axis.</param>
        /// <param name="xIntervalValue">The value of each interval on the X-axis.</param>
        /// <param name="yIntervalValue">The value of each interval on the Y-axis.</param>
        /// <param name="scale">The DrawingScale object used for mapping data to the drawing.</param>
        /// <param name="strTitle">The title of the diagram.</param>
        public DrawAxes(Graphics g, Panel panel, int xInterval, int yInterval,
            int xIntervalValue, int yIntervalValue, DrawingScale scale, string strTitle)
        {
            graphics = g;
            this.panel = panel;
            this.xInterval = xInterval;
            this.yInterval = yInterval;
            this.xIntervalValue = xIntervalValue;
            this.yIntervalValue = yIntervalValue;
            this.scale = scale;

            Draw(strTitle);
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Draws the axes on the panel.
        /// </summary>
        /// <param name="diagramTitle">The title of the diagram.</param>
        private void Draw(string diagramTitle)
        {
            Pen pen = new Pen(Color.Black, 2);

            #region Create Axes Lines
            PointF startAxis = new PointF((float)scale.Margin, -(float)scale.Margin);
            PointF endHorizontal = new PointF((float)scale.ScaleWidth + (float)scale.Margin, -(float)scale.Margin);
            PointF endVertical = new PointF((float)scale.Margin, -(float)scale.ScaleHeight - (float)scale.Margin);

            graphics.DrawLine(pen, startAxis, endHorizontal);
            graphics.DrawLine(pen, startAxis, endVertical);
            #endregion

            // Create space between interval dashes
            float intervalSpace = ((float)scale.ScaleWidth + (float)scale.Margin) / xInterval;
            
            // Points for dashes    
            PointF intStart = new PointF();
            PointF intEnd = new PointF();

            #region Draw Horizontal Dashes and Write Intervalls
            Font font = new Font("Times New Roman", 9);
            for (int i = 0; i < xInterval + 1; i++)
            {
                // Calculate insertion points
                intStart.X = (float)startAxis.X + (float)(xIntervalValue * scale.ScaleXMargin) * i;
                intStart.Y = startAxis.Y - 3;

                intEnd = intStart;
                intEnd.Y += 6;

                // Draw dash
                graphics.DrawLine(pen, intStart, intEnd);

                // Update insertion points
                intStart.X -= 8;
                intStart.Y += 8;

                // Draw Text
                graphics.DrawString((xIntervalValue * i).ToString(), font, Brushes.Black, intStart);
            }
            #endregion

            #region Draw Vertical Dashes and Write Intervalls
            // Set space between interval dashes
            intervalSpace = (float)scale.ScaleHeight / yInterval;

            // Create vertical dashes
            for (int i = 0; i < yInterval + 1; i++)
            {
                // Calculate insertion points
                intStart.Y = startAxis.Y + (-intervalSpace * i);
                intStart.X = startAxis.X - 3;

                intEnd = intStart;
                intEnd.X += 6;

                // Draw dash
                graphics.DrawLine(pen, intStart, intEnd);

                // Update insertion points
                intStart.X -= 24;
                intStart.Y -= 8;

                // Draw Text
                graphics.DrawString((yIntervalValue * i).ToString(), font, Brushes.Black, intStart);
            }
            #endregion

            #region Draw Title
            SolidBrush brush = new SolidBrush(Color.Black);
            
            // Set the position of the title
            float textPos = panel.Width / 2 - diagramTitle.Length / 2 * 12; ;
            
            graphics.DrawString(diagramTitle, new Font("Times New Roman", 18), brush, textPos, -(panel.Height - 10));
            #endregion

            brush.Dispose();
            pen.Dispose();
        }
        #endregion
    }
}
