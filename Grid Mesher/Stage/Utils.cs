using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public static class Utils
    {
        public static Point ConvertToBitmapPoint(Vector3 v, LockBitmap lb)
        {
            int width = lb.Width - 1;
            int height = lb.Height - 1;
            int x = (int)(v[0] * width);
            int y = (int)((Consts.YMax - v[1]) * height);
            return new Point(x, y);
        }
        public static float GetZ(float x, float y)
        {
            return 0;
        }
    }
}
