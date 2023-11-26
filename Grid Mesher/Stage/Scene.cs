using Grid_Mesher.Stage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Drawing.SetColor(bitmap, Consts.firstColor);
            Configuration.background = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), bitmap.PixelFormat);
            pictureBox.Image = bitmap;
            this.lockmap = new LockBitmap(bitmap);
            this.pictureBox = pictureBox;

            Configuration.Z = new float[4, 4] { { 0, 0.5f, 0.3f, 0 }, { 0.3f, 0.2f, 0.2f, 0.1f }, { 0.1f, 0.2f, 0.2f, 0.1f }, { 0, 0.1f, 0.1f, 0 } };

            Draw(true);
        }

        public void Draw(bool resetBackGround = false)
        {
            if (resetBackGround)
                SetUpTriangulation();
            lockmap.LockBits();
            triangulation.Draw(lockmap);
            lockmap.UnlockBits();
        }

        public void SetUpTriangulation()
        {
            triangulation = new Triangulation(Configuration.XTriCount, Configuration.YTriCount);
        }
        public void Clear()
        {
            lockmap.LockBits();
            Drawing.ClearLB(lockmap, pictureBox.BackColor);
            lockmap.UnlockBits();
        }
        public void SetNormalBitmapFromFile(string imagePath)
        {
            Bitmap bt = new Bitmap(imagePath);
            Bitmap scaledBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(scaledBitmap))
            {
                g.DrawImage(bt, 0, 0, pictureBox.Width, pictureBox.Height);
            }
            Utils.MakeNormalMap(scaledBitmap);
        }
    }
}
