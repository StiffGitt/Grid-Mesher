using Grid_Mesher.Stage;
using System.Windows.Forms;

namespace Grid_Mesher
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Scene scene;
        private bool zBoxChanged = false;
        private int ticksThisSecond = 0;
        public Form()
        {
            InitializeComponent();
            Initialize();
            SetConfiguration();
            this.scene = new Scene(pictureBox);
            SetNormalMap();
            pictureBox.Refresh();
        }
        private void Initialize()
        {
            xBox.Items.AddRange(Enumerable.Range(0, 4).Select(x => x.ToString()).ToArray());
            xBox.SelectedIndex = 0;
            yBox.Items.AddRange(Enumerable.Range(0, 4).Select(x => x.ToString()).ToArray());
            yBox.SelectedIndex = 0;
        }
        private void triXTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Configuration.XTriCount = triXTrackBar.Value;
            triXLabel.Text = "x: " + Configuration.XTriCount;
            Draw(true);
        }

        private void triYTrackBar_Scroll(object sender, EventArgs e)
        {
            Configuration.YTriCount = triYTrackBar.Value;
            triYLabel.Text = "y: " + Configuration.YTriCount;
            Draw(true);
        }
        private void SetConfiguration()
        {
            Configuration.XTriCount = triXTrackBar.Value;
            Configuration.YTriCount = triYTrackBar.Value;
            Configuration.Kd = (float)KdTrackBar.Value / 100;
            Configuration.Ks = (float)KsTrackBar.Value / 100;
            Configuration.M = mTrackBar.Value;
            Configuration.ShouldDrawGrid = drawGridCheckbox.Checked;
            Configuration.ShouldDrawBackground = !onlyGridBox1.Checked;
            Light.Position = new System.Numerics.Vector3(Light.Position.X, Light.Position.Y, (float)zLightTrackBar.Value / 100);
            Configuration.ShouldNormalMap = normalCheckBox.Checked;
            triXLabel.Text = "x: " + Configuration.XTriCount;
            triYLabel.Text = "y: " + Configuration.YTriCount;
            kdLabel.Text = "kd: " + Configuration.Kd;
            ksLabel.Text = "ks: " + Configuration.Ks;
            mLabel.Text = "m: " + Configuration.M;
            zLabel.Text = (zTrackBar.Value * Consts.XMax / zTrackBar.Maximum).ToString();
            zLightLabel.Text = ((float)zLightTrackBar.Value / 100).ToString();
            Consts.BackColor = pictureBox.BackColor;
        }
        private void SetNormalMap()
        {
            string resourcesPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\resources\\";
            string fileName = "bricks.jpg";
            scene.SetNormalBitmapFromFile(resourcesPath + fileName);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            this.scene = new Scene(pictureBox);
            Draw();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Drawing.SetColor(Configuration.background, colorDialog.Color);
                Draw(true);
            }
        }
        private void Draw(bool resetBackGround = false)
        {
            if (scene != null)
                scene.Draw(resetBackGround);
            pictureBox.Refresh();
            ticksThisSecond++;
        }

        private void KdTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Configuration.Kd = (float)KdTrackBar.Value / 100;
            kdLabel.Text = "kd: " + Configuration.Kd;
            Draw();
        }

        private void KsTrackBar_Scroll(object sender, EventArgs e)
        {
            Configuration.Ks = (float)KsTrackBar.Value / 100;
            ksLabel.Text = "ks: " + Configuration.Ks;
            Draw();
        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            Configuration.M = mTrackBar.Value;
            mLabel.Text = "m: " + Configuration.M;
            Draw();
        }

        private void selectLightButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Configuration.Il = Utils.Vector3FromRGB(colorDialog.Color);
                Draw();
            }
        }

        private void drawGridCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.ShouldDrawGrid = drawGridCheckbox.Checked;
            Draw();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Wybierz obraz";
            openFileDialog.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Wszystkie pliki|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Bitmap bt = new Bitmap(imagePath);
                Bitmap scaledBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                using (Graphics g = Graphics.FromImage(scaledBitmap))
                {
                    g.DrawImage(bt, 0, 0, pictureBox.Width, pictureBox.Height);
                }

                Configuration.background = scaledBitmap;
            }
            Draw(true);
        }

        private void box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xBox.SelectedItem != null && yBox.SelectedItem != null)
            {
                zTrackBar.Value = (int)(Configuration.Z[int.Parse((string)xBox.SelectedItem), int.Parse((string)yBox.SelectedItem)] / Consts.XMax * zTrackBar.Maximum);
                zLabel.Text = (zTrackBar.Value * Consts.XMax / zTrackBar.Maximum).ToString();
                zBoxChanged = true;
            }
        }

        private void zTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Configuration.Z[int.Parse((string)xBox.SelectedItem), int.Parse((string)yBox.SelectedItem)] = (float)zTrackBar.Value / zTrackBar.Maximum;
            zLabel.Text = (zTrackBar.Value * Consts.XMax / zTrackBar.Maximum).ToString();
            if (!zBoxChanged)
            {
                Draw(true);
            }
            else
                zBoxChanged = false;
        }

        private void animationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.ShouldAnimate = animationCheckBox.Checked;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animationCheckBox.Checked)
            {
                Light.Animate();
                Draw();
            }
        }

        private void zLightTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Light.Position = new System.Numerics.Vector3(Light.Position.X, Light.Position.Y, (float)zLightTrackBar.Value / 100);
            zLightLabel.Text = ((float)zLightTrackBar.Value / 100).ToString();
            Draw();
        }

        private void normalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.ShouldNormalMap = normalCheckBox.Checked;
            Draw();
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Wybierz obraz";
            openFileDialog.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Wszystkie pliki|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                scene.SetNormalBitmapFromFile(openFileDialog.FileName);
            }
            Draw();
        }


        private void fpsTimer_Tick(object sender, EventArgs e)
        {
            this.Text = "Grid Mesher: " + (ticksThisSecond).ToString() + "FPS";
            ticksThisSecond = 0;
        }

        private void onlyGridBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!drawGridCheckbox.Checked)
                return;
            Configuration.ShouldDrawBackground = !onlyGridBox1.Checked;
            Draw(true);
        }

        private void replaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.ShouldReplace = replaceCheckBox.Checked;
            Draw();
        }

        private void sphereCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.ShouldSphere = sphereCheckBox.Checked;
            Draw(true);
        }
    }
}