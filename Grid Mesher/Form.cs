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
            Configuration.xTriCount = triXTrackBar.Value;
            scene.SetUpTriangulation();
            pictureBox.Refresh();
        }

        private void triYTrackBar_Scroll(object sender, EventArgs e)
        {
            Configuration.yTriCount = triYTrackBar.Value;
            scene.SetUpTriangulation();
            pictureBox.Refresh();
        }
        private void SetConfiguration()
        {
            Configuration.xTriCount = triXTrackBar.Value;
            Configuration.yTriCount = triYTrackBar.Value;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            this.scene = new Scene(pictureBox);
            pictureBox.Refresh();
        }
    }
}