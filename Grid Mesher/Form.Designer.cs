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
            flowLayoutPanel1 = new FlowLayoutPanel();
            selectLightButton = new Button();
            selectColorButton = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            triYTrackBar = new TrackBar();
            triXTrackBar = new TrackBar();
            groupBox2 = new GroupBox();
            label6 = new Label();
            mTrackBar = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            KsTrackBar = new TrackBar();
            KdTrackBar = new TrackBar();
            colorDialog = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)triYTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triXTrackBar).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KsTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KdTrackBar).BeginInit();
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
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 0);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(selectLightButton);
            flowLayoutPanel1.Controls.Add(selectColorButton);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(706, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(275, 555);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // selectLightButton
            // 
            selectLightButton.Location = new Point(3, 3);
            selectLightButton.Name = "selectLightButton";
            selectLightButton.Size = new Size(272, 30);
            selectLightButton.TabIndex = 6;
            selectLightButton.Text = "Select light color ...";
            selectLightButton.UseVisualStyleBackColor = true;
            selectLightButton.Click += selectLightButton_Click;
            // 
            // selectColorButton
            // 
            selectColorButton.Dock = DockStyle.Top;
            selectColorButton.Location = new Point(3, 39);
            selectColorButton.Name = "selectColorButton";
            selectColorButton.RightToLeft = RightToLeft.No;
            selectColorButton.Size = new Size(272, 30);
            selectColorButton.TabIndex = 5;
            selectColorButton.Text = "Select background color...";
            selectColorButton.UseVisualStyleBackColor = true;
            selectColorButton.Click += selectColorButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(triYTrackBar);
            groupBox1.Controls.Add(triXTrackBar);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 89);
            groupBox1.TabIndex = 3;
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
            triYTrackBar.ValueChanged += triYTrackBar_Scroll;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(mTrackBar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(KsTrackBar);
            groupBox2.Controls.Add(KdTrackBar);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 129);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lighting parameters";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(4, 86);
            label6.Name = "label6";
            label6.Size = new Size(24, 21);
            label6.TabIndex = 5;
            label6.Text = "m";
            // 
            // mTrackBar
            // 
            mTrackBar.AutoSize = false;
            mTrackBar.Location = new Point(27, 86);
            mTrackBar.Maximum = 100;
            mTrackBar.Minimum = 1;
            mTrackBar.Name = "mTrackBar";
            mTrackBar.Size = new Size(230, 26);
            mTrackBar.TabIndex = 4;
            mTrackBar.TickStyle = TickStyle.None;
            mTrackBar.Value = 10;
            mTrackBar.Scroll += mTrackBar_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 54);
            label4.Name = "label4";
            label4.Size = new Size(25, 21);
            label4.TabIndex = 3;
            label4.Text = "ks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 22);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 2;
            label5.Text = "kd";
            // 
            // KsTrackBar
            // 
            KsTrackBar.AutoSize = false;
            KsTrackBar.Location = new Point(27, 54);
            KsTrackBar.Maximum = 100;
            KsTrackBar.Name = "KsTrackBar";
            KsTrackBar.Size = new Size(230, 26);
            KsTrackBar.TabIndex = 1;
            KsTrackBar.TickStyle = TickStyle.None;
            KsTrackBar.Value = 50;
            KsTrackBar.Scroll += KsTrackBar_Scroll;
            // 
            // KdTrackBar
            // 
            KdTrackBar.AutoSize = false;
            KdTrackBar.Location = new Point(27, 22);
            KdTrackBar.Maximum = 100;
            KdTrackBar.Name = "KdTrackBar";
            KdTrackBar.Size = new Size(230, 26);
            KdTrackBar.TabIndex = 0;
            KdTrackBar.TickStyle = TickStyle.None;
            KdTrackBar.Value = 50;
            KdTrackBar.ValueChanged += KdTrackBar_ValueChanged;
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
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)triYTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)triXTrackBar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KsTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KdTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TrackBar triYTrackBar;
        private TrackBar triXTrackBar;
        private GroupBox groupBox2;
        private Label label6;
        private TrackBar mTrackBar;
        private Label label4;
        private Label label5;
        private TrackBar KsTrackBar;
        private TrackBar KdTrackBar;
        private Button selectColorButton;
        private ColorDialog colorDialog;
        private Button selectLightButton;
    }
}