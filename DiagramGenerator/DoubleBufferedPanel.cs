using System.Windows.Forms;

namespace DiagramGenerator
{
    public class DoubleBufferedPanel : Panel
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Creates a double buffered panel which fixes flickering
        /// when many updates are done on the GUI.
        /// </summary>
        public DoubleBufferedPanel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint,
                true);

            this.UpdateStyles();
        }
        #endregion
    }
}
