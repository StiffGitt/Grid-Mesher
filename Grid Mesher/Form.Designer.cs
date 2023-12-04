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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            selectLightButton = new Button();
            imageButton = new Button();
            selectColorButton = new Button();
            groupBox1 = new GroupBox();
            onlyGridBox1 = new CheckBox();
            drawGridCheckbox = new CheckBox();
            triYLabel = new Label();
            triXLabel = new Label();
            triYTrackBar = new TrackBar();
            triXTrackBar = new TrackBar();
            groupBox2 = new GroupBox();
            zLightLabel = new Label();
            zLightTrackBar = new TrackBar();
            animationCheckBox = new CheckBox();
            mLabel = new Label();
            mTrackBar = new TrackBar();
            ksLabel = new Label();
            kdLabel = new Label();
            KsTrackBar = new TrackBar();
            KdTrackBar = new TrackBar();
            groupBox3 = new GroupBox();
            zLabel = new Label();
            zTrackBar = new TrackBar();
            label8 = new Label();
            yBox = new ComboBox();
            label7 = new Label();
            xBox = new ComboBox();
            groupBox4 = new GroupBox();
            sphereCheckBox = new CheckBox();
            replaceCheckBox = new CheckBox();
            normalCheckBox = new CheckBox();
            normalButton = new Button();
            colorDialog = new ColorDialog();
            animationTimer = new System.Windows.Forms.Timer(components);
            fpsTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)triYTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triXTrackBar).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zLightTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KsTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KdTrackBar).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zTrackBar).BeginInit();
            groupBox4.SuspendLayout();
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
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1125, 748);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(804, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 748);
            label1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(3, 4);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(795, 740);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(selectLightButton);
            flowLayoutPanel1.Controls.Add(imageButton);
            flowLayoutPanel1.Controls.Add(selectColorButton);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(807, 4);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(315, 740);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // selectLightButton
            // 
            selectLightButton.Location = new Point(3, 4);
            selectLightButton.Margin = new Padding(3, 4, 3, 4);
            selectLightButton.Name = "selectLightButton";
            selectLightButton.Size = new Size(311, 40);
            selectLightButton.TabIndex = 6;
            selectLightButton.Text = "Select light color ...";
            selectLightButton.UseVisualStyleBackColor = true;
            selectLightButton.Click += selectLightButton_Click;
            // 
            // imageButton
            // 
            imageButton.Location = new Point(3, 51);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(151, 53);
            imageButton.TabIndex = 5;
            imageButton.Text = "Select background image ...";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // selectColorButton
            // 
            selectColorButton.Dock = DockStyle.Top;
            selectColorButton.Location = new Point(160, 52);
            selectColorButton.Margin = new Padding(3, 4, 3, 4);
            selectColorButton.Name = "selectColorButton";
            selectColorButton.RightToLeft = RightToLeft.No;
            selectColorButton.Size = new Size(150, 53);
            selectColorButton.TabIndex = 7;
            selectColorButton.Text = "Select background color...";
            selectColorButton.UseVisualStyleBackColor = true;
            selectColorButton.Click += selectColorButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(onlyGridBox1);
            groupBox1.Controls.Add(drawGridCheckbox);
            groupBox1.Controls.Add(triYLabel);
            groupBox1.Controls.Add(triXLabel);
            groupBox1.Controls.Add(triYTrackBar);
            groupBox1.Controls.Add(triXTrackBar);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 113);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(311, 147);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Triangulation accuracy";
            // 
            // onlyGridBox1
            // 
            onlyGridBox1.AutoSize = true;
            onlyGridBox1.Location = new Point(145, 113);
            onlyGridBox1.Margin = new Padding(3, 4, 3, 4);
            onlyGridBox1.Name = "onlyGridBox1";
            onlyGridBox1.Size = new Size(121, 24);
            onlyGridBox1.TabIndex = 5;
            onlyGridBox1.Text = "And only grid";
            onlyGridBox1.UseVisualStyleBackColor = true;
            onlyGridBox1.CheckedChanged += onlyGridBox1_CheckedChanged;
            // 
            // drawGridCheckbox
            // 
            drawGridCheckbox.AutoSize = true;
            drawGridCheckbox.Location = new Point(6, 115);
            drawGridCheckbox.Name = "drawGridCheckbox";
            drawGridCheckbox.Size = new Size(145, 24);
            drawGridCheckbox.TabIndex = 4;
            drawGridCheckbox.Text = "Should draw grid";
            drawGridCheckbox.UseVisualStyleBackColor = true;
            drawGridCheckbox.CheckedChanged += drawGridCheckbox_CheckedChanged;
            // 
            // triYLabel
            // 
            triYLabel.AutoSize = true;
            triYLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            triYLabel.Location = new Point(5, 72);
            triYLabel.Name = "triYLabel";
            triYLabel.Size = new Size(26, 28);
            triYLabel.TabIndex = 3;
            triYLabel.Text = "y:";
            // 
            // triXLabel
            // 
            triXLabel.AutoSize = true;
            triXLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            triXLabel.Location = new Point(5, 29);
            triXLabel.Name = "triXLabel";
            triXLabel.Size = new Size(25, 28);
            triXLabel.TabIndex = 2;
            triXLabel.Text = "x:";
            // 
            // triYTrackBar
            // 
            triYTrackBar.AutoSize = false;
            triYTrackBar.Location = new Point(50, 72);
            triYTrackBar.Margin = new Padding(3, 4, 3, 4);
            triYTrackBar.Maximum = 100;
            triYTrackBar.Minimum = 5;
            triYTrackBar.Name = "triYTrackBar";
            triYTrackBar.Size = new Size(243, 35);
            triYTrackBar.TabIndex = 1;
            triYTrackBar.TickStyle = TickStyle.None;
            triYTrackBar.Value = 20;
            triYTrackBar.ValueChanged += triYTrackBar_Scroll;
            // 
            // triXTrackBar
            // 
            triXTrackBar.AutoSize = false;
            triXTrackBar.Location = new Point(50, 29);
            triXTrackBar.Margin = new Padding(3, 4, 3, 4);
            triXTrackBar.Maximum = 100;
            triXTrackBar.Minimum = 5;
            triXTrackBar.Name = "triXTrackBar";
            triXTrackBar.Size = new Size(243, 35);
            triXTrackBar.TabIndex = 0;
            triXTrackBar.TickStyle = TickStyle.None;
            triXTrackBar.Value = 20;
            triXTrackBar.ValueChanged += triXTrackBar_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(zLightLabel);
            groupBox2.Controls.Add(zLightTrackBar);
            groupBox2.Controls.Add(animationCheckBox);
            groupBox2.Controls.Add(mLabel);
            groupBox2.Controls.Add(mTrackBar);
            groupBox2.Controls.Add(ksLabel);
            groupBox2.Controls.Add(kdLabel);
            groupBox2.Controls.Add(KsTrackBar);
            groupBox2.Controls.Add(KdTrackBar);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 268);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(311, 251);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lighting parameters";
            // 
            // zLightLabel
            // 
            zLightLabel.AutoSize = true;
            zLightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zLightLabel.Location = new Point(5, 197);
            zLightLabel.Name = "zLightLabel";
            zLightLabel.Size = new Size(25, 28);
            zLightLabel.TabIndex = 8;
            zLightLabel.Text = "z:";
            // 
            // zLightTrackBar
            // 
            zLightTrackBar.AutoSize = false;
            zLightTrackBar.Location = new Point(50, 197);
            zLightTrackBar.Margin = new Padding(3, 4, 3, 4);
            zLightTrackBar.Maximum = 100;
            zLightTrackBar.Name = "zLightTrackBar";
            zLightTrackBar.Size = new Size(243, 35);
            zLightTrackBar.TabIndex = 7;
            zLightTrackBar.TickStyle = TickStyle.None;
            zLightTrackBar.Value = 30;
            zLightTrackBar.ValueChanged += zLightTrackBar_ValueChanged;
            // 
            // animationCheckBox
            // 
            animationCheckBox.AutoSize = true;
            animationCheckBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            animationCheckBox.Location = new Point(10, 157);
            animationCheckBox.Margin = new Padding(3, 4, 3, 4);
            animationCheckBox.Name = "animationCheckBox";
            animationCheckBox.Size = new Size(121, 29);
            animationCheckBox.TabIndex = 6;
            animationCheckBox.Text = "Animation";
            animationCheckBox.UseVisualStyleBackColor = true;
            animationCheckBox.CheckedChanged += animationCheckBox_CheckedChanged;
            // 
            // mLabel
            // 
            mLabel.AutoSize = true;
            mLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mLabel.Location = new Point(5, 115);
            mLabel.Name = "mLabel";
            mLabel.Size = new Size(33, 28);
            mLabel.TabIndex = 5;
            mLabel.Text = "m:";
            // 
            // mTrackBar
            // 
            mTrackBar.AutoSize = false;
            mTrackBar.Location = new Point(50, 115);
            mTrackBar.Margin = new Padding(3, 4, 3, 4);
            mTrackBar.Maximum = 100;
            mTrackBar.Minimum = 1;
            mTrackBar.Name = "mTrackBar";
            mTrackBar.Size = new Size(243, 35);
            mTrackBar.TabIndex = 4;
            mTrackBar.TickStyle = TickStyle.None;
            mTrackBar.Value = 10;
            mTrackBar.Scroll += mTrackBar_Scroll;
            // 
            // ksLabel
            // 
            ksLabel.AutoSize = true;
            ksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ksLabel.Location = new Point(5, 72);
            ksLabel.Name = "ksLabel";
            ksLabel.Size = new Size(34, 28);
            ksLabel.TabIndex = 3;
            ksLabel.Text = "ks:";
            // 
            // kdLabel
            // 
            kdLabel.AutoSize = true;
            kdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kdLabel.Location = new Point(5, 29);
            kdLabel.Name = "kdLabel";
            kdLabel.Size = new Size(38, 28);
            kdLabel.TabIndex = 2;
            kdLabel.Text = "kd:";
            // 
            // KsTrackBar
            // 
            KsTrackBar.AutoSize = false;
            KsTrackBar.Location = new Point(50, 72);
            KsTrackBar.Margin = new Padding(3, 4, 3, 4);
            KsTrackBar.Maximum = 100;
            KsTrackBar.Name = "KsTrackBar";
            KsTrackBar.Size = new Size(243, 35);
            KsTrackBar.TabIndex = 1;
            KsTrackBar.TickStyle = TickStyle.None;
            KsTrackBar.Value = 50;
            KsTrackBar.Scroll += KsTrackBar_Scroll;
            // 
            // KdTrackBar
            // 
            KdTrackBar.AutoSize = false;
            KdTrackBar.Location = new Point(50, 29);
            KdTrackBar.Margin = new Padding(3, 4, 3, 4);
            KdTrackBar.Maximum = 100;
            KdTrackBar.Name = "KdTrackBar";
            KdTrackBar.Size = new Size(243, 35);
            KdTrackBar.TabIndex = 0;
            KdTrackBar.TickStyle = TickStyle.None;
            KdTrackBar.Value = 50;
            KdTrackBar.ValueChanged += KdTrackBar_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zLabel);
            groupBox3.Controls.Add(zTrackBar);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(yBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(xBox);
            groupBox3.Location = new Point(3, 526);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(307, 87);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Z";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zLabel.Location = new Point(5, 51);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(25, 28);
            zLabel.TabIndex = 6;
            zLabel.Text = "z:";
            // 
            // zTrackBar
            // 
            zTrackBar.AutoSize = false;
            zTrackBar.Location = new Point(50, 56);
            zTrackBar.Margin = new Padding(3, 4, 3, 4);
            zTrackBar.Maximum = 100;
            zTrackBar.Name = "zTrackBar";
            zTrackBar.Size = new Size(243, 35);
            zTrackBar.TabIndex = 5;
            zTrackBar.TickStyle = TickStyle.None;
            zTrackBar.Value = 10;
            zTrackBar.ValueChanged += zTrackBar_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(127, 24);
            label8.Name = "label8";
            label8.Size = new Size(25, 25);
            label8.TabIndex = 3;
            label8.Text = "y:";
            // 
            // yBox
            // 
            yBox.FormattingEnabled = true;
            yBox.Location = new Point(158, 21);
            yBox.Name = "yBox";
            yBox.Size = new Size(59, 28);
            yBox.TabIndex = 2;
            yBox.SelectedIndexChanged += box_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(31, 24);
            label7.Name = "label7";
            label7.Size = new Size(25, 25);
            label7.TabIndex = 1;
            label7.Text = "x:";
            // 
            // xBox
            // 
            xBox.FormattingEnabled = true;
            xBox.Location = new Point(62, 21);
            xBox.Name = "xBox";
            xBox.Size = new Size(59, 28);
            xBox.TabIndex = 0;
            xBox.SelectedIndexChanged += box_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(sphereCheckBox);
            groupBox4.Controls.Add(replaceCheckBox);
            groupBox4.Controls.Add(normalCheckBox);
            groupBox4.Controls.Add(normalButton);
            groupBox4.Location = new Point(3, 620);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(307, 120);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Normal map";
            // 
            // sphereCheckBox
            // 
            sphereCheckBox.AutoSize = true;
            sphereCheckBox.Location = new Point(6, 88);
            sphereCheckBox.Name = "sphereCheckBox";
            sphereCheckBox.Size = new Size(99, 24);
            sphereCheckBox.TabIndex = 3;
            sphereCheckBox.Text = "Do sphere";
            sphereCheckBox.UseVisualStyleBackColor = true;
            sphereCheckBox.CheckedChanged += sphereCheckBox_CheckedChanged;
            // 
            // replaceCheckBox
            // 
            replaceCheckBox.AutoSize = true;
            replaceCheckBox.Location = new Point(163, 57);
            replaceCheckBox.Margin = new Padding(3, 4, 3, 4);
            replaceCheckBox.Name = "replaceCheckBox";
            replaceCheckBox.Size = new Size(130, 24);
            replaceCheckBox.TabIndex = 2;
            replaceCheckBox.Text = "Should replace";
            replaceCheckBox.UseVisualStyleBackColor = true;
            replaceCheckBox.CheckedChanged += replaceCheckBox_CheckedChanged;
            // 
            // normalCheckBox
            // 
            normalCheckBox.AutoSize = true;
            normalCheckBox.Location = new Point(6, 57);
            normalCheckBox.Margin = new Padding(3, 4, 3, 4);
            normalCheckBox.Name = "normalCheckBox";
            normalCheckBox.Size = new Size(145, 24);
            normalCheckBox.TabIndex = 1;
            normalCheckBox.Text = "Normal mapping";
            normalCheckBox.UseVisualStyleBackColor = true;
            normalCheckBox.CheckedChanged += normalCheckBox_CheckedChanged;
            // 
            // normalButton
            // 
            normalButton.Location = new Point(10, 28);
            normalButton.Margin = new Padding(3, 4, 3, 4);
            normalButton.Name = "normalButton";
            normalButton.Size = new Size(283, 31);
            normalButton.TabIndex = 0;
            normalButton.Text = "Select normal map ...";
            normalButton.UseVisualStyleBackColor = true;
            normalButton.Click += normalButton_Click;
            // 
            // animationTimer
            // 
            animationTimer.Enabled = true;
            animationTimer.Interval = 50;
            animationTimer.Tick += animationTimer_Tick;
            // 
            // fpsTimer
            // 
            fpsTimer.Enabled = true;
            fpsTimer.Interval = 1000;
            fpsTimer.Tick += fpsTimer_Tick;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 748);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form";
            Text = "Grid Mesher";
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
            ((System.ComponentModel.ISupportInitialize)zLightTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)mTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KsTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KdTrackBar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zTrackBar).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Label triYLabel;
        private Label triXLabel;
        private TrackBar triYTrackBar;
        private TrackBar triXTrackBar;
        private GroupBox groupBox2;
        private Label mLabel;
        private TrackBar mTrackBar;
        private Label ksLabel;
        private Label kdLabel;
        private TrackBar KsTrackBar;
        private TrackBar KdTrackBar;
        private Button selectColorButton;
        private ColorDialog colorDialog;
        private Button selectLightButton;
        private CheckBox drawGridCheckbox;
        private Button imageButton;
        private GroupBox groupBox3;
        private Label label7;
        private ComboBox xBox;
        private Label label8;
        private ComboBox yBox;
        private TrackBar zTrackBar;
        private CheckBox animationCheckBox;
        private System.Windows.Forms.Timer animationTimer;
        private Label zLabel;
        private Label zLightLabel;
        private TrackBar zLightTrackBar;
        private GroupBox groupBox4;
        private Button normalButton;
        private CheckBox normalCheckBox;
        private System.Windows.Forms.Timer fpsTimer;
        private CheckBox onlyGridBox1;
        private CheckBox replaceCheckBox;
        private CheckBox sphereCheckBox;
    }
}