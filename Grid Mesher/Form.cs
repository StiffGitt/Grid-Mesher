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
            SetConfiguration();
            this.scene = new Scene(pictureBox);
            pictureBox.Refresh();
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
                Configuration.Color = colorDialog.Color;
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
    }
}