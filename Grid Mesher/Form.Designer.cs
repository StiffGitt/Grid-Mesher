namespace Grid_Mesher
{
    partial class Form
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            triYTrackBar = new TrackBar();
            triXTrackBar = new TrackBar();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)triYTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triXTrackBar).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(984, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(703, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 561);
            label1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(694, 555);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(triYTrackBar);
            groupBox1.Controls.Add(triXTrackBar);
            groupBox1.Location = new Point(706, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 89);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Triangulation accuracy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 54);
            label3.Name = "label3";
            label3.Size = new Size(18, 21);
            label3.TabIndex = 3;
            label3.Text = "y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 22);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 2;
            label2.Text = "x";
            // 
            // triYTrackBar
            // 
            triYTrackBar.AutoSize = false;
            triYTrackBar.Location = new Point(27, 54);
            triYTrackBar.Maximum = 100;
            triYTrackBar.Minimum = 5;
            triYTrackBar.Name = "triYTrackBar";
            triYTrackBar.Size = new Size(230, 26);
            triYTrackBar.TabIndex = 1;
            triYTrackBar.TickStyle = TickStyle.None;
            triYTrackBar.Value = 20;
            triYTrackBar.Scroll += triYTrackBar_Scroll;
            // 
            // triXTrackBar
            // 
            triXTrackBar.AutoSize = false;
            triXTrackBar.Location = new Point(27, 22);
            triXTrackBar.Maximum = 100;
            triXTrackBar.Minimum = 5;
            triXTrackBar.Name = "triXTrackBar";
            triXTrackBar.Size = new Size(230, 26);
            triXTrackBar.TabIndex = 0;
            triXTrackBar.TickStyle = TickStyle.None;
            triXTrackBar.Value = 20;
            triXTrackBar.ValueChanged += triXTrackBar_ValueChanged;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "Form";
            Text = "Grid Mesher";
            Resize += Form_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)triYTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)triXTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox;
        private GroupBox groupBox1;
        private TrackBar triXTrackBar;
        private Label label3;
        private Label label2;
        private TrackBar triYTrackBar;
    }
}