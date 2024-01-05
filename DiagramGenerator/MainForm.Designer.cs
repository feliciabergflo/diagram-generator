namespace DiagramGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSettings = new GroupBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            txtValueY = new TextBox();
            txtValueX = new TextBox();
            txtDivisionsX = new TextBox();
            txtDivisionsY = new TextBox();
            txtTitle = new TextBox();
            lblSettingsY = new Label();
            lblSettingsX = new Label();
            lblInterval = new Label();
            lblDivisions = new Label();
            lblTitle = new Label();
            grpPoints = new GroupBox();
            btnAddPoint = new Button();
            listPoints = new ListBox();
            txtPointY = new TextBox();
            txtPointX = new TextBox();
            lblPoints = new Label();
            lblPointY = new Label();
            lblPointX = new Label();
            btnClear = new Button();
            pnlGraph = new DoubleBufferedPanel();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuData = new ToolStripMenuItem();
            mnuSortInX = new ToolStripMenuItem();
            mnuSortInY = new ToolStripMenuItem();
            grpSettings.SuspendLayout();
            grpPoints.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpSettings
            // 
            grpSettings.Controls.Add(btnCancel);
            grpSettings.Controls.Add(btnConfirm);
            grpSettings.Controls.Add(txtValueY);
            grpSettings.Controls.Add(txtValueX);
            grpSettings.Controls.Add(txtDivisionsX);
            grpSettings.Controls.Add(txtDivisionsY);
            grpSettings.Controls.Add(txtTitle);
            grpSettings.Controls.Add(lblSettingsY);
            grpSettings.Controls.Add(lblSettingsX);
            grpSettings.Controls.Add(lblInterval);
            grpSettings.Controls.Add(lblDivisions);
            grpSettings.Controls.Add(lblTitle);
            grpSettings.Location = new Point(17, 46);
            grpSettings.Name = "grpSettings";
            grpSettings.Size = new Size(308, 233);
            grpSettings.TabIndex = 0;
            grpSettings.TabStop = false;
            grpSettings.Text = "Settings";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ScrollBar;
            btnCancel.Location = new Point(9, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.GradientInactiveCaption;
            btnConfirm.Location = new Point(172, 190);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(125, 29);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtValueY
            // 
            txtValueY.Location = new Point(238, 129);
            txtValueY.Name = "txtValueY";
            txtValueY.Size = new Size(59, 27);
            txtValueY.TabIndex = 11;
            // 
            // txtValueX
            // 
            txtValueX.Location = new Point(150, 129);
            txtValueX.Name = "txtValueX";
            txtValueX.Size = new Size(59, 27);
            txtValueX.TabIndex = 10;
            // 
            // txtDivisionsX
            // 
            txtDivisionsX.Location = new Point(150, 96);
            txtDivisionsX.Name = "txtDivisionsX";
            txtDivisionsX.Size = new Size(59, 27);
            txtDivisionsX.TabIndex = 9;
            // 
            // txtDivisionsY
            // 
            txtDivisionsY.Location = new Point(238, 96);
            txtDivisionsY.Name = "txtDivisionsY";
            txtDivisionsY.Size = new Size(59, 27);
            txtDivisionsY.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(150, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(147, 27);
            txtTitle.TabIndex = 3;
            // 
            // lblSettingsY
            // 
            lblSettingsY.AutoSize = true;
            lblSettingsY.Location = new Point(261, 73);
            lblSettingsY.Name = "lblSettingsY";
            lblSettingsY.Size = new Size(16, 20);
            lblSettingsY.TabIndex = 7;
            lblSettingsY.Text = "y";
            // 
            // lblSettingsX
            // 
            lblSettingsX.AutoSize = true;
            lblSettingsX.Location = new Point(172, 73);
            lblSettingsX.Name = "lblSettingsX";
            lblSettingsX.Size = new Size(16, 20);
            lblSettingsX.TabIndex = 6;
            lblSettingsX.Text = "x";
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInterval.Location = new Point(9, 135);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(104, 20);
            lblInterval.TabIndex = 5;
            lblInterval.Text = "Interval Value";
            // 
            // lblDivisions
            // 
            lblDivisions.AutoSize = true;
            lblDivisions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDivisions.Location = new Point(9, 99);
            lblDivisions.Name = "lblDivisions";
            lblDivisions.Size = new Size(117, 20);
            lblDivisions.TabIndex = 4;
            lblDivisions.Text = "No. of Divisions";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(9, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(101, 20);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Diagram Title";
            // 
            // grpPoints
            // 
            grpPoints.Controls.Add(btnAddPoint);
            grpPoints.Controls.Add(listPoints);
            grpPoints.Controls.Add(txtPointY);
            grpPoints.Controls.Add(txtPointX);
            grpPoints.Controls.Add(lblPoints);
            grpPoints.Controls.Add(lblPointY);
            grpPoints.Controls.Add(lblPointX);
            grpPoints.Location = new Point(17, 299);
            grpPoints.Name = "grpPoints";
            grpPoints.Size = new Size(308, 346);
            grpPoints.TabIndex = 1;
            grpPoints.TabStop = false;
            grpPoints.Text = "Add Point";
            // 
            // btnAddPoint
            // 
            btnAddPoint.BackColor = SystemColors.GradientInactiveCaption;
            btnAddPoint.Location = new Point(172, 107);
            btnAddPoint.Name = "btnAddPoint";
            btnAddPoint.Size = new Size(125, 29);
            btnAddPoint.TabIndex = 13;
            btnAddPoint.Text = "Add";
            btnAddPoint.UseVisualStyleBackColor = false;
            btnAddPoint.Click += btnAddPoint_Click;
            // 
            // listPoints
            // 
            listPoints.FormattingEnabled = true;
            listPoints.Location = new Point(172, 168);
            listPoints.Name = "listPoints";
            listPoints.Size = new Size(125, 164);
            listPoints.TabIndex = 12;
            // 
            // txtPointY
            // 
            txtPointY.Location = new Point(172, 65);
            txtPointY.Name = "txtPointY";
            txtPointY.Size = new Size(125, 27);
            txtPointY.TabIndex = 11;
            // 
            // txtPointX
            // 
            txtPointX.Location = new Point(172, 31);
            txtPointX.Name = "txtPointX";
            txtPointX.Size = new Size(125, 27);
            txtPointX.TabIndex = 9;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoints.Location = new Point(7, 165);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(103, 20);
            lblPoints.TabIndex = 10;
            lblPoints.Text = "Added Points";
            // 
            // lblPointY
            // 
            lblPointY.AutoSize = true;
            lblPointY.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPointY.Location = new Point(9, 67);
            lblPointY.Name = "lblPointY";
            lblPointY.Size = new Size(97, 20);
            lblPointY.TabIndex = 9;
            lblPointY.Text = "y-coordinate";
            // 
            // lblPointX
            // 
            lblPointX.AutoSize = true;
            lblPointX.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPointX.Location = new Point(9, 31);
            lblPointX.Name = "lblPointX";
            lblPointX.Size = new Size(97, 20);
            lblPointX.TabIndex = 8;
            lblPointX.Text = "x-coordinate";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ScrollBar;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(737, 590);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(231, 49);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear Diagram";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlGraph
            // 
            pnlGraph.BorderStyle = BorderStyle.FixedSingle;
            pnlGraph.Cursor = Cursors.Cross;
            pnlGraph.Location = new Point(356, 56);
            pnlGraph.Name = "pnlGraph";
            pnlGraph.Size = new Size(616, 520);
            pnlGraph.TabIndex = 4;
            pnlGraph.Paint += pnlGraph_Paint;
            pnlGraph.MouseDoubleClick += pnlGraph_MouseDoubleClick;
            pnlGraph.MouseMove += pnlGraph_MouseMove;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuData });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuData
            // 
            mnuData.DropDownItems.AddRange(new ToolStripItem[] { mnuSortInX, mnuSortInY });
            mnuData.Name = "mnuData";
            mnuData.Size = new Size(55, 24);
            mnuData.Text = "Data";
            // 
            // mnuSortInX
            // 
            mnuSortInX.Name = "mnuSortInX";
            mnuSortInX.Size = new Size(224, 26);
            mnuSortInX.Text = "Sort in x-dir";
            mnuSortInX.Click += mnuSortInX_Click;
            // 
            // mnuSortInY
            // 
            mnuSortInY.Name = "mnuSortInY";
            mnuSortInY.Size = new Size(224, 26);
            mnuSortInY.Text = "Sort in y-dir";
            mnuSortInY.Click += mnuSortInY_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 662);
            Controls.Add(pnlGraph);
            Controls.Add(btnClear);
            Controls.Add(grpPoints);
            Controls.Add(grpSettings);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Diagram Generator";
            grpSettings.ResumeLayout(false);
            grpSettings.PerformLayout();
            grpPoints.ResumeLayout(false);
            grpPoints.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSettings;
        private GroupBox grpPoints;
        private Label lblSettingsY;
        private Label lblSettingsX;
        private Label lblInterval;
        private Label lblDivisions;
        private Label lblTitle;
        private Label lblPoints;
        private Label lblPointY;
        private Label lblPointX;
        private TextBox txtDivisionsY;
        private TextBox txtTitle;
        private TextBox txtPointY;
        private TextBox txtPointX;
        private TextBox txtValueY;
        private TextBox txtValueX;
        private TextBox txtDivisionsX;
        private ListBox listPoints;
        private Button btnCancel;
        private Button btnConfirm;
        private Button btnAddPoint;
        private Button btnClear;
        private DoubleBufferedPanel pnlGraph;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuData;
        private ToolStripMenuItem mnuSortInX;
        private ToolStripMenuItem mnuSortInY;
    }
}
