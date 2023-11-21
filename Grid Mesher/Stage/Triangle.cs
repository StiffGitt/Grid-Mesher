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
        public Vector3[] Nt { get; set; }


        public void Draw(LockBitmap lb)
        {
            Point Ap = Utils.ConvertToDrawingPoint(A, lb);
            Point Bp = Utils.ConvertToDrawingPoint(B, lb);
            Point Cp = Utils.ConvertToDrawingPoint(C, lb);
            Drawing.FillPolygon(lb, new Point[] { Ap, Bp, Cp }, this);
            if (Configuration.ShouldDrawGrid)
            {
                Drawing.DrawLine(lb, gridColor, Ap, Bp);
                Drawing.DrawLine(lb, gridColor, Bp, Cp);
                Drawing.DrawLine(lb, gridColor, Cp, Ap);
            }
        }

        public (float alfa, float beta, float gamma) GetBar(PointF P)
        {
            float alfa = ((B.Y * C.X - C.Y * B.X) + (C.Y * P.X - P.Y * C.X) + (P.Y * B.X - B.Y * P.X)) /
                ((B.Y * C.X - C.Y * B.X) + (C.Y * A.X - A.Y * C.X) + (A.Y * B.X - B.Y * A.X));
            float beta = ((C.Y * A.X - A.Y * C.X) + (A.Y * P.X - P.Y * A.X) + (P.Y * C.X - C.Y * P.X)) /
                ((B.Y * C.X - C.Y * B.X) + (C.Y * A.X - A.Y * C.X) + (A.Y * B.X - B.Y * A.X));
            float gamma = 1 - alfa - beta;
            return (alfa, beta, gamma);
        }
    }
}
