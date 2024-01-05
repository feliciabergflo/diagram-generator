using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiagramGenerator
{
    /// <summary>
    /// Represents the MainForm and handles the user interaction.
    /// </summary>
    public partial class MainForm : Form
    {
        #region FIELDS
        private DiagramData data; // Data for the diagram
        private PointF mousePos;
        private List<PointF> points = new List<PointF>();
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            data = new DiagramData();

            InitializeGUI();
        }
        #endregion

        /// <summary>
        /// Enables and disables controls.
        /// </summary>
        private void InitializeGUI()
        {
            grpSettings.Enabled = true;
            grpPoints.Enabled = false;
            pnlGraph.Enabled = false;
        }

        /// <summary>
        /// Updates and fills the list with points.
        /// </summary>
        private void UpdateList()
        {
            listPoints.Items.Clear();
            foreach (PointF point in data.Points)
            {
                listPoints.Items.Add(string.Format("({0:f2}, {1:f2})", point.X.ToString(), point.Y.ToString()));
            }
        }

        /// <summary>
        /// Event handler for confirming user settings. 
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                listPoints.Items.Clear();

                data.XIntervals = int.Parse(txtDivisionsX.Text);
                data.YIntervals = int.Parse(txtDivisionsY.Text);
                data.XIntervalValue = int.Parse(txtValueX.Text);
                data.YIntervalValue = int.Parse(txtValueY.Text);

                grpSettings.Enabled = false;
                grpPoints.Enabled = true;
                pnlGraph.Enabled = true;
                pnlGraph.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felaktig inmatning", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Event handles for adding a point.
        /// </summary>
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            AddPoint();
            txtPointX.Text = "";
            txtPointY.Text = "";
        }

        /// <summary>
        /// Handles addition of a new point and displays it in the GUI. 
        /// </summary>
        private void AddPoint()
        {
            try
            {
                float x = float.Parse(txtPointX.Text);
                float y = float.Parse(txtPointY.Text);

                // Validate data and create new point
                data.ValidateData(x, y);
                data.AddPoint(x, y);

                // Update listbox
                listPoints.Items.Add(string.Format("({0:f2}, {1:f2})", x.ToString(), y.ToString()));

                // Update panel
                pnlGraph.Invalidate();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Coordinate data incorrect. {ex.Message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Event handler for painting on the graph. Paints the axes, the cross and 
        /// the diagram on the panel.
        /// </summary>
        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            DrawDiagram diagram;
            DrawCross cross;
            DrawAxes axes;

            if (pnlGraph.Enabled)
            {
                g = e.Graphics;
                g.TranslateTransform(0, pnlGraph.Height);

                DrawingScale scale = scale = new DrawingScale(pnlGraph.Width, pnlGraph.Height,
                    data.XIntervals * data.XIntervalValue, data.YIntervals * data.YIntervalValue, 0.1);

                // Draw the axes
                axes = new DrawAxes(g, pnlGraph, data.XIntervals, data.YIntervals,
                    data.XIntervalValue, data.YIntervalValue, scale, txtTitle.Text);

                // Draw cross
                cross = new DrawCross(g, pnlGraph, mousePos, scale);

                // Draw the diagram
                diagram = new DrawDiagram(g, pnlGraph, data, scale);
            }
        }

        /// <summary>
        /// Event handler for when user moves the mouse over the panel. 
        /// </summary>
        private void pnlGraph_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = new PointF(e.X, e.Y);
            pnlGraph.Invalidate();
        }

        /// <summary>
        /// Event handler for when user double clicks the panel to create 
        /// a new point on the diagram.
        /// </summary>
        private void pnlGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DrawingScale scale = scale = new DrawingScale(pnlGraph.Width, pnlGraph.Height,
            data.XIntervals * data.XIntervalValue, data.YIntervals * data.YIntervalValue, 0.1);

            PointF pos = new PointF(e.X, e.Y);

            pos.X = (float)((pos.X - scale.Margin) / scale.ScaleXMargin);
            pos.Y = (float)((pnlGraph.Height - pos.Y - scale.Margin) / scale.ScaleYMargin);

            txtPointX.Text = pos.X.ToString("0.00");
            txtPointY.Text = pos.Y.ToString("0.00");
            AddPoint();
        }

        /// <summary>
        /// Clears the diagram and lets the user re-set the settings.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the settings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pnlGraph.Enabled = false;
                grpSettings.Enabled = true;
                grpPoints.Enabled = false;

                data.Clear();
                listPoints.Items.Clear();
                txtPointX.Text = "";
                txtPointY.Text = "";
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Cancels and resets all input in the settings group box.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtDivisionsX.Text = "";
            txtDivisionsY.Text = "";
            txtValueX.Text = "";
            txtValueY.Text = "";
        }

        /// <summary>
        /// Sorts the data points by their x-value.
        /// </summary>
        private void mnuSortInX_Click(object sender, EventArgs e)
        {
            data.SortData("x");
            UpdateList();
            pnlGraph.Invalidate();
        }

        /// <summary>
        /// Sorts the data points by their y-value.
        /// </summary>
        private void mnuSortInY_Click(object sender, EventArgs e)
        {
            data.SortData("y");
            UpdateList();
            pnlGraph.Invalidate();
        }
    }
}
