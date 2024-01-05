using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DiagramGenerator
{
    /// <summary>
    /// Responsible for drawing a crosshair on a panel and display the current 
    /// center point of the crosshair.
    /// </summary>
    public class DrawCross
    {
        #region FIELDS
        private Graphics graphics;
        private Panel panel;
        private PointF pos;
        private DrawingScale scale;
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the DrawCross class.
        /// </summary>
        /// <param name="g">The graphics object used for drawing.</param>
        /// <param name="panel">The panel to draw the crosshair on.</param>
        /// <param name="pos">The center point of the crosshair.</param>
        /// <param name="scale">The drawing scale to control coordinate transoformations.</param>
        public DrawCross(Graphics g, Panel panel, PointF pos, DrawingScale scale)
        {
            this.graphics = g;
            this.panel = panel;
            this.pos = pos;
            this.scale = scale;

            Draw();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Draws a crosshair on the panel and displays the current 
        /// center point of the crosshair. 
        /// </summary>
        public void Draw()
        {
            // Create dashed pen to draw with
            Pen pen = new Pen(Color.LightGray, 2);
            pen.DashStyle = DashStyle.DashDotDot;

            // Control that drawing does not go out of boundaries 
            bool XOutOfBoundaries = DrawHorizontalDashLine(pen);
            bool YOutOfBoundaries = DrawVerticalDashLine(pen);

            DrawCoordinateText(XOutOfBoundaries || YOutOfBoundaries);
            pen.Dispose();
        }

        /// <summary>
        /// Draws the horizontal dashed line of the crosshair.
        /// </summary>
        /// <param name="pen">The pen used for drawing.</param>
        /// <returns>True if the line is outside the drawing boundaries; otherwise false.</returns>
        private bool DrawHorizontalDashLine(Pen pen)
        {
            // Define start and end points of the vertical dashed line
            PointF start = new PointF();
            PointF end = new PointF();

            // Set the starting point
            start.X = (float)scale.Margin;
            start.Y = (pos.Y - panel.Height);

            // Set the ending point
            end.X = panel.Width - (float)scale.Margin;
            end.Y = (pos.Y - panel.Height);

            // Check boundaries and adjust if needed
            bool outOfBoundaries = true;
            if (start.Y > -(float)scale.Margin)
            {
                start.Y = -(float)scale.Margin;
                end.Y = start.Y;
            }
            else if (start.Y < -(panel.Height - (float)scale.Margin))
            {
                start.Y = -(panel.Height - (float)scale.Margin);
                end.Y = start.Y;
            }
            else
            {
                // If the starting point is within boundaries, set to false
                outOfBoundaries = false;
            }

            // Draw the vertical dashed line
            graphics.DrawLine(pen, start, end);
            return outOfBoundaries;
        }

        /// <summary>
        /// Draws the vertical dashed line of the crosshair.
        /// </summary>
        /// <param name="pen">The pen used for drawing.</param>
        /// <returns>True if the line is outside the drawing boundaries; otherwise false.</returns>
        private bool DrawVerticalDashLine(Pen pen)
        {
            // Define start and end points of the vertical dashed line
            PointF start = new PointF();
            PointF end = new PointF();

            // Set the starting point
            start.X = pos.X; 
            start.Y = -(float)scale.Margin; 

            // Set the ending point
            end.X = pos.X;
            end.Y = -(panel.Height - (float)scale.Margin);

            // Check boundaries and adjust if needed
            bool outOfBoundaries = true;
            if (start.X < scale.Margin)
            {
                start.X = (float)scale.Margin;
                end.X = start.X;
            }
            else if (start.X > panel.Width - (float)scale.Margin)
            {
                start.X = panel.Width - (float)scale.Margin;
                end.X = start.X;
            }
            else
            {
                // If the starting point is within boundaries, set to false
                outOfBoundaries = false;
            }

            // Draw the vertical dashed line
            graphics.DrawLine(pen, start, end);
            return outOfBoundaries;
        }

        /// <summary>
        /// Draws the text displaying coordinates if the crosshair is within boundaries.
        /// </summary>
        /// <param name="outOfBoundaries">True if the crosshair is outside the drawing boundaries; otherwise false.</param>
        private void DrawCoordinateText(bool outOfBoundaries)
        {
            PointF textPoint = new PointF();
            textPoint.X = pos.X;
            textPoint.Y = -(panel.Height - pos.Y);

            // Draw coordinates if in boundaries
            if (!outOfBoundaries)
            {
                graphics.DrawString(string.Format(" ({0:0.00} {1:0.00})", (pos.X - scale.Margin) / scale.ScaleXMargin,
                    (panel.Height - pos.Y - scale.Margin) / scale.ScaleYMargin), new Font("Arial", 12),
                    Brushes.Red, textPoint);
            }
        }
        #endregion
    }
}
