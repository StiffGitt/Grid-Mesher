using Grid_Mesher.Stage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher
{
    public class Scene
    {
        private LockBitmap lockmap;
        private Triangulation triangulation;
        private PictureBox pictureBox;

        public Scene(PictureBox pictureBox)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
            pictureBox.Image = bitmap;
            this.lockmap = new LockBitmap(bitmap);
            this.pictureBox = pictureBox;
            SetUpTriangulation();
            Draw();
        }

        public void Draw()
        {
            lockmap.LockBits();
            Clear();
            triangulation.DrawGrid(lockmap);
            lockmap.UnlockBits();
        }

        public void SetUpTriangulation()
        {
            triangulation = new Triangulation(Configuration.xTriCount, Configuration.yTriCount);
            Draw();
        }
        private void Clear()
        {
            Drawing.FillBitmap(lockmap, pictureBox.BackColor);
        }
    }
}
