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
            drawGridCheckbox = new CheckBox();
            triYLabel = new Label();
            triXLabel = new Label();
            triYTrackBar = new TrackBar();
            triXTrackBar = new TrackBar();
            groupBox2 = new GroupBox();
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
            colorDialog = new ColorDialog();
            animationTimer = new System.Windows.Forms.Timer(components);
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
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zTrackBar).BeginInit();
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
            flowLayoutPanel1.Controls.Add(imageButton);
            flowLayoutPanel1.Controls.Add(selectColorButton);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
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
            // imageButton
            // 
            imageButton.Location = new Point(3, 38);
            imageButton.Margin = new Padding(3, 2, 3, 2);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(132, 40);
            imageButton.TabIndex = 5;
            imageButton.Text = "Select background image ...";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // selectColorButton
            // 
            selectColorButton.Dock = DockStyle.Top;
            selectColorButton.Location = new Point(141, 39);
            selectColorButton.Name = "selectColorButton";
            selectColorButton.RightToLeft = RightToLeft.No;
            selectColorButton.Size = new Size(131, 40);
            selectColorButton.TabIndex = 7;
            selectColorButton.Text = "Select background color...";
            selectColorButton.UseVisualStyleBackColor = true;
            selectColorButton.Click += selectColorButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(drawGridCheckbox);
            groupBox1.Controls.Add(triYLabel);
            groupBox1.Controls.Add(triXLabel);
            groupBox1.Controls.Add(triYTrackBar);
            groupBox1.Controls.Add(triXTrackBar);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Triangulation accuracy";
            // 
            // drawGridCheckbox
            // 
            drawGridCheckbox.AutoSize = true;
            drawGridCheckbox.Location = new Point(5, 86);
            drawGridCheckbox.Margin = new Padding(3, 2, 3, 2);
            drawGridCheckbox.Name = "drawGridCheckbox";
            drawGridCheckbox.Size = new Size(116, 19);
            drawGridCheckbox.TabIndex = 4;
            drawGridCheckbox.Text = "Should draw grid";
            drawGridCheckbox.UseVisualStyleBackColor = true;
            drawGridCheckbox.CheckedChanged += drawGridCheckbox_CheckedChanged;
            // 
            // triYLabel
            // 
            triYLabel.AutoSize = true;
            triYLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            triYLabel.Location = new Point(4, 54);
            triYLabel.Name = "triYLabel";
            triYLabel.Size = new Size(21, 21);
            triYLabel.TabIndex = 3;
            triYLabel.Text = "y:";
            // 
            // triXLabel
            // 
            triXLabel.AutoSize = true;
            triXLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            triXLabel.Location = new Point(4, 22);
            triXLabel.Name = "triXLabel";
            triXLabel.Size = new Size(20, 21);
            triXLabel.TabIndex = 2;
            triXLabel.Text = "x:";
            // 
            // triYTrackBar
            // 
            triYTrackBar.AutoSize = false;
            triYTrackBar.Location = new Point(44, 54);
            triYTrackBar.Maximum = 100;
            triYTrackBar.Minimum = 5;
            triYTrackBar.Name = "triYTrackBar";
            triYTrackBar.Size = new Size(213, 26);
            triYTrackBar.TabIndex = 1;
            triYTrackBar.TickStyle = TickStyle.None;
            triYTrackBar.Value = 20;
            triYTrackBar.ValueChanged += triYTrackBar_Scroll;
            // 
            // triXTrackBar
            // 
            triXTrackBar.AutoSize = false;
            triXTrackBar.Location = new Point(44, 22);
            triXTrackBar.Maximum = 100;
            triXTrackBar.Minimum = 5;
            triXTrackBar.Name = "triXTrackBar";
            triXTrackBar.Size = new Size(213, 26);
            triXTrackBar.TabIndex = 0;
            triXTrackBar.TickStyle = TickStyle.None;
            triXTrackBar.Value = 20;
            triXTrackBar.ValueChanged += triXTrackBar_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(animationCheckBox);
            groupBox2.Controls.Add(mLabel);
            groupBox2.Controls.Add(mTrackBar);
            groupBox2.Controls.Add(ksLabel);
            groupBox2.Controls.Add(kdLabel);
            groupBox2.Controls.Add(KsTrackBar);
            groupBox2.Controls.Add(KdTrackBar);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 160);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lighting parameters";
            // 
            // animationCheckBox
            // 
            animationCheckBox.AutoSize = true;
            animationCheckBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            animationCheckBox.Location = new Point(9, 118);
            animationCheckBox.Name = "animationCheckBox";
            animationCheckBox.Size = new Size(97, 24);
            animationCheckBox.TabIndex = 6;
            animationCheckBox.Text = "Animation";
            animationCheckBox.UseVisualStyleBackColor = true;
            animationCheckBox.CheckedChanged += animationCheckBox_CheckedChanged;
            // 
            // mLabel
            // 
            mLabel.AutoSize = true;
            mLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mLabel.Location = new Point(4, 86);
            mLabel.Name = "mLabel";
            mLabel.Size = new Size(27, 21);
            mLabel.TabIndex = 5;
            mLabel.Text = "m:";
            // 
            // mTrackBar
            // 
            mTrackBar.AutoSize = false;
            mTrackBar.Location = new Point(44, 86);
            mTrackBar.Maximum = 100;
            mTrackBar.Minimum = 1;
            mTrackBar.Name = "mTrackBar";
            mTrackBar.Size = new Size(213, 26);
            mTrackBar.TabIndex = 4;
            mTrackBar.TickStyle = TickStyle.None;
            mTrackBar.Value = 10;
            mTrackBar.Scroll += mTrackBar_Scroll;
            // 
            // ksLabel
            // 
            ksLabel.AutoSize = true;
            ksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ksLabel.Location = new Point(4, 54);
            ksLabel.Name = "ksLabel";
            ksLabel.Size = new Size(28, 21);
            ksLabel.TabIndex = 3;
            ksLabel.Text = "ks:";
            // 
            // kdLabel
            // 
            kdLabel.AutoSize = true;
            kdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kdLabel.Location = new Point(4, 22);
            kdLabel.Name = "kdLabel";
            kdLabel.Size = new Size(30, 21);
            kdLabel.TabIndex = 2;
            kdLabel.Text = "kd:";
            // 
            // KsTrackBar
            // 
            KsTrackBar.AutoSize = false;
            KsTrackBar.Location = new Point(44, 54);
            KsTrackBar.Maximum = 100;
            KsTrackBar.Name = "KsTrackBar";
            KsTrackBar.Size = new Size(213, 26);
            KsTrackBar.TabIndex = 1;
            KsTrackBar.TickStyle = TickStyle.None;
            KsTrackBar.Value = 50;
            KsTrackBar.Scroll += KsTrackBar_Scroll;
            // 
            // KdTrackBar
            // 
            KdTrackBar.AutoSize = false;
            KdTrackBar.Location = new Point(44, 22);
            KdTrackBar.Maximum = 100;
            KdTrackBar.Name = "KdTrackBar";
            KdTrackBar.Size = new Size(213, 26);
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
            groupBox3.Location = new Point(3, 366);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(269, 94);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Z";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zLabel.Location = new Point(4, 38);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(20, 21);
            zLabel.TabIndex = 6;
            zLabel.Text = "z:";
            // 
            // zTrackBar
            // 
            zTrackBar.AutoSize = false;
            zTrackBar.Location = new Point(44, 42);
            zTrackBar.Maximum = 100;
            zTrackBar.Name = "zTrackBar";
            zTrackBar.Size = new Size(213, 26);
            zTrackBar.TabIndex = 5;
            zTrackBar.TickStyle = TickStyle.None;
            zTrackBar.Value = 10;
            zTrackBar.ValueChanged += zTrackBar_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(111, 18);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 3;
            label8.Text = "y:";
            // 
            // yBox
            // 
            yBox.FormattingEnabled = true;
            yBox.Location = new Point(138, 16);
            yBox.Margin = new Padding(3, 2, 3, 2);
            yBox.Name = "yBox";
            yBox.Size = new Size(52, 23);
            yBox.TabIndex = 2;
            yBox.SelectedIndexChanged += box_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 18);
            label7.Name = "label7";
            label7.Size = new Size(19, 20);
            label7.TabIndex = 1;
            label7.Text = "x:";
            // 
            // xBox
            // 
            xBox.FormattingEnabled = true;
            xBox.Location = new Point(54, 16);
            xBox.Margin = new Padding(3, 2, 3, 2);
            xBox.Name = "xBox";
            xBox.Size = new Size(52, 23);
            xBox.TabIndex = 0;
            xBox.SelectedIndexChanged += box_SelectedIndexChanged;
            // 
            // animationTimer
            // 
            animationTimer.Enabled = true;
            animationTimer.Interval = 1;
            animationTimer.Tick += animationTimer_Tick;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tableLayoutPanel1);
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
            ((System.ComponentModel.ISupportInitialize)mTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KsTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KdTrackBar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zTrackBar).EndInit();
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
    }
}