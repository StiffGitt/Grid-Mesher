using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_Mesher.Stage
{
    public static class Drawing
    {
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
            DrawLineWithBresenham(lb, color, a, b);
        }
        public static void FillBitmap(LockBitmap lb, Color color)
        {
            for (int x = 0; x < lb.Width; x++)
                for (int y = 0; y < lb.Height; y++)
                    lb.SetPixel(x, y, color);
        }
        public static void FillPolygon(LockBitmap lb, Color color, Point[] points)
        {
            List<(Point, Point)> AET = new List<(Point, Point)> ();
            int[] sortedPoints = points.Select((x, i) => new KeyValuePair<Point, int>(x, i))
                .OrderBy(x => x.Key.Y).Select(x => x.Value).ToArray();
            int ymin = points[sortedPoints[0]].Y; int ymax = points[sortedPoints[sortedPoints.Length - 1]].Y;
            int lastFound = -1;
            for (int y = ymin + 1; y <= ymax; y++)
            {
                while ()
            }
        }
    }
}
