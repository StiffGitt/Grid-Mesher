using Grid_Mesher.Stage;
using System.Windows.Forms;

namespace Grid_Mesher
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Scene scene;
        public Form()
        {
            InitializeComponent();
            Initialize();
            SetConfiguration();
            this.scene = new Scene(pictureBox);
            pictureBox.Refresh();
        }
        private void Initialize()
        {
            xBox.Items.AddRange(Enumerable.Range(1, 4).Select(x => x.ToString()).ToArray());
            xBox.SelectedIndex = 0;
            yBox.Items.AddRange(Enumerable.Range(1, 4).Select(x => x.ToString()).ToArray());
            yBox.SelectedIndex = 0;
        }
        private void triXTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Configuration.XTriCount = triXTrackBar.Value;
            scene.SetUpTriangulation();
            Draw();
        }

        private void triYTrackBar_Scroll(object sender, EventArgs e)
        {
            Configuration.YTriCount = triYTrackBar.Value;
            scene.SetUpTriangulation();
            Draw();
        }
        private void SetConfiguration()
        {
            Configuration.XTriCount = triXTrackBar.Value;
            Configuration.YTriCount = triYTrackBar.Value;
            Configuration.Kd = (float)KdTrackBar.Value / 100;
            Configuration.Ks = (float)KsTrackBar.Value / 100;
            Configuration.M = mTrackBar.Value;
            Configuration.ShouldDrawGrid = drawGridCheckbox.Checked;
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
                Draw();
            }
        }
        private void Draw()
        {
            scene.Draw();
            pictureBox.Refresh();
        }

        private void KdTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Configuration.Kd = (float)KdTrackBar.Value / 100;
            Draw();
        }

        private void KsTrackBar_Scroll(object sender, EventArgs e)
        {
            Configuration.Ks = (float)KsTrackBar.Value / 100;
            Draw();
        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            Configuration.M = mTrackBar.Value;
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
            Draw();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}