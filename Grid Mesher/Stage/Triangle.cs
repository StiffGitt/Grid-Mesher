using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public struct Triangle
    {
        private readonly static Color gridColor = Color.Black;
        public Vector3 A {  get; set; }
        public Vector3 B {  get; set; }
        public Vector3 C {  get; set; }

        public void Draw(LockBitmap lb)
        {
            Point Ap = Utils.ConvertToBitmapPoint(A, lb);
            Point Bp = Utils.ConvertToBitmapPoint(B, lb);
            Point Cp = Utils.ConvertToBitmapPoint(C, lb);
            Drawing.FillPolygon(lb, Color.Goldenrod, new Point[] { Ap, Bp, Cp });
            Drawing.DrawLine(lb, gridColor, Ap, Bp);
            Drawing.DrawLine(lb, gridColor, Bp, Cp);
            Drawing.DrawLine(lb, gridColor, Cp, Ap);
        }
    }
}
