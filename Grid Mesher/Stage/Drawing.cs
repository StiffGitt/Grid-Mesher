using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_Mesher.Stage
{
    public static class Drawing
    {
        private struct AETev
        {
            public float x;
            public int ymax;
            public float coeff;

            public AETev DoStep()
            {
                return new AETev() {coeff = this.coeff, x = this.x + this.coeff, ymax = this.ymax};
            }
        }
        private static void DrawLineDown(LockBitmap lb, Color color, Point a, Point b)
        {
            int dx = b.X - a.X, dy = b.Y - a.Y, yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int d0 = (2 * dy) - dx;
            for (int x = a.X, y = a.Y; x <= b.X; x++)
            {
                lb.SetPixel(x, y, color);
                if (d0 > 0)
                {
                    y += yi;
                    d0 += 2 * (dy - dx);
                }
                else
                    d0 += 2 * dy;
            }

        }
        private static void DrawLineUp(LockBitmap lb, Color color, Point a, Point b)
        {
            int dx = b.X - a.X, dy = b.Y - a.Y, xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int d0 = (2 * dx) - dy;
            for (int x = a.X, y = a.Y; y <= b.Y; y++)
            {
                lb.SetPixel(x, y, color);
                if (d0 > 0)
                {
                    x += xi;
                    d0 += 2 * (dx - dy);
                }
                else
                    d0 += 2 * dx;
            }
        }
        private static void DrawLineWithBresenham(LockBitmap lb, Color color, Point a, Point b)
        {
            if (Math.Abs(b.Y - a.Y) < Math.Abs(b.X - a.X))
            {
                if (a.X > b.X)
                    DrawLineDown(lb, color, b, a);
                else
                    DrawLineDown(lb, color, a, b);
            }
            else
            {
                if (a.Y > b.Y)
                    DrawLineUp(lb, color, b, a);
                else
                    DrawLineUp(lb, color, a, b);
            }
        }
        public static void DrawLine(LockBitmap lb, Color color, Point a, Point b)
        {
            DrawLineWithBresenham(lb, color, new Point(a.X, lb.Height - a.Y), new Point(b.X, lb.Height - b.Y));
        }
        public static void FillBitmap(LockBitmap lb, Color color)
        {
            for (int x = 0; x < lb.Width; x++)
                for (int y = 0; y < lb.Height; y++)
                    lb.SetPixel(x, y, color);
        }
        public static void FillPolygon(LockBitmap lb, Color color, Point[] points, Triangle triangle)
        {
            int n = points.Length;
            List<AETev> AET = new List<AETev> ();
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
                    for (int x = (int) AET[i].x; x < AET[i + 1].x; x++)
                    {
                        Color newColor = Utils.GetColorForPixel(triangle, color, new PointF((float)x / lb.Width, (float)y / lb.Height));
                        lb.SetPixel(x, lb.Height - y, newColor);
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
