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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(694, 555);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox;
    }
}