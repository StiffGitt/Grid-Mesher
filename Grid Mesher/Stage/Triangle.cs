using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public struct Triangle
    {
        private struct AETev
        {
            public float x;
            public int ymax;
            public float coeff;

            public AETev DoStep()
            {
                return new AETev() { coeff = this.coeff, x = this.x + this.coeff, ymax = this.ymax };
            }
        }

        private readonly static Color gridColor = Color.Black;
        public Vector3 A {  get; set; }
        public Vector3 B {  get; set; }
        public Vector3 C {  get; set; }
        public Vector3[] Nt { get; set; }
        public List<Pixel> Pixels { get; set; }

        public Triangle()
        {
            Pixels = new List<Pixel>();
            
        }
        public void GetPixels()
        {
            Point Ap = Utils.ConvertToDrawingPoint(A);
            Point Bp = Utils.ConvertToDrawingPoint(B);
            Point Cp = Utils.ConvertToDrawingPoint(C);
            ScanLine(new Point[] { Ap, Bp, Cp });
        }
        public void Draw(LockBitmap lb)
        {
            if (Configuration.ShouldDrawBackground)
                Drawing.DrawTriangle(lb, this);
            if (Configuration.ShouldDrawGrid)
            {
                Point Ap = Utils.ConvertToDrawingPoint(A, lb);
                Point Bp = Utils.ConvertToDrawingPoint(B, lb);
                Point Cp = Utils.ConvertToDrawingPoint(C, lb);
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

        private void ScanLine(Point[] points)
        {
            int n = points.Length;
            List<AETev> AET = new List<AETev>();
            int[] sortedPoints = points.Select((x, i) => new KeyValuePair<Point, int>(x, i))
                .OrderBy(x => x.Key.Y).Select(x => x.Value).ToArray();
            int ymin = points[sortedPoints[0]].Y; int ymax = points[sortedPoints[sortedPoints.Length - 1]].Y;
            int lastFound = -1, prev, next;
            for (int y = ymin + 1; y <= ymax; y++)
            {
                while (lastFound < n)
                {
                    Point curPoint = points[sortedPoints[lastFound + 1]];
                    if (curPoint.Y > y - 1)
                        break;
                    lastFound++;
                    prev = (sortedPoints[lastFound] - 1 < 0) ? n - 1 : sortedPoints[lastFound] - 1;
                    next = (sortedPoints[lastFound] + 1) % n;
                    if (points[next].Y > y - 1)
                        AET.Add(new AETev { coeff = Utils.GetCoeff(curPoint, points[next]), x = curPoint.X, ymax = points[next].Y });
                    else if (points[next].Y < y - 1)
                        AET.Remove(new AETev { coeff = Utils.GetCoeff(curPoint, points[next]), x = curPoint.X, ymax = curPoint.Y });
                    if (points[prev].Y > y - 1)
                        AET.Add(new AETev { coeff = Utils.GetCoeff(curPoint, points[prev]), x = curPoint.X, ymax = points[prev].Y });
                    else if (points[prev].Y < y - 1)
                        AET.Remove(new AETev { coeff = Utils.GetCoeff(curPoint, points[prev]), x = curPoint.X, ymax = curPoint.Y });
                }

                AET = AET.OrderBy(x => x.x).ToList();

                for (int i = 0; i < AET.Count; i += 2)
                {
                    for (int x = (int)AET[i].x; x < AET[i + 1].x; x++)
                    {
                        var pf = new PointF((float)x / Configuration.background.Width, (float)y / Configuration.background.Height);
                        var bar = GetBar(pf);
                        Vector3 P = new Vector3()
                        {
                            X = pf.X,
                            Y = pf.Y,
                            Z = (Configuration.ShouldSphere)? Utils.GetZ(pf.X, pf.Y) : bar.alfa * A.Z + bar.beta * B.Z + bar.gamma * C.Z
                        };
                        var N = Nt[0] * bar.alfa + Nt[1] * bar.beta + Nt[2] * bar.gamma;
                        //if (Configuration.ShouldSphere)
                        //{
                        //    if ((Math.Sqrt((P.X - Consts.SC.X) * (P.X - Consts.SC.X) + (P.Y - Consts.SC.Y) * (P.Y - Consts.SC.Y)) > Consts.R))
                        //        N = new Vector3(0, 0, 1);
                        //}
                        Pixels.Add(new Pixel()
                        {
                            X = x,
                            Y = y,
                            P = P,
                            N = N,
                            Color = Configuration.background.GetPixel(x, Configuration.background.Height - y)
                        });
                        
                    }
                }

                for (int i = 0; i < AET.Count; i++)
                {
                    AET[i] = AET[i].DoStep();
                }
            }
        }
    }
}
