using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramGenerator
{
    /// <summary>
    /// Responsible for drawing a diagram on a panel.
    /// </summary>
    public class DrawDiagram
    {
        #region FIELDS
        private Graphics graphics;
        private Panel panel;
        private DiagramData data;
        private DrawingScale scale;
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the DrawDiagram class.
        /// </summary>
        /// <param name="g">The graphics object used for drawing.</param>
        /// <param name="panel">The panel where the diagram is drawn.</param>
        /// <param name="data">The diagram data containing points to be drawn.</param>
        /// <param name="scale">The drawing scale used for mapping data to the drawing.</param>
        public DrawDiagram(Graphics g, Panel panel, DiagramData data, DrawingScale scale)
        {
            this.graphics = g;
            this.panel = panel;
            this.data = data;
            this.scale = scale;

            Draw();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Draws the diagram on the panel based on the provided data points and scale.
        /// </summary>
        public void Draw()
        {
            // Create pen to draw with
            Pen pen = new Pen(Color.Blue, 2);
            PointF previousPoint;

            // Check if there are any points
            if (data.Points.Count > 1)
            {
                previousPoint = new PointF(); // Previous point
                previousPoint = data.Points[0]; // Set first point as previous

                for (int i = 1; i < data.Points.Count; i++)
                {
                    // Draw line between points
                    graphics.DrawLine(pen, ((previousPoint.X * (float)scale.ScaleXMargin) + (float)scale.Margin),
                        -((previousPoint.Y * (float)scale.ScaleYMargin) + (float)scale.Margin),
                        ((data.Points[i].X * (float)scale.ScaleXMargin) + (float)scale.Margin),
                        -((data.Points[i].Y * (float)scale.ScaleYMargin) + (float)scale.Margin));

                    // Set lats point as the previous for next iteration
                    previousPoint = data.Points[i];
                }

                pen.Dispose();
            }
        }
        #endregion
    }
}
