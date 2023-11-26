using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            DrawLineWithBresenham(lb, color, new Point(a.X, lb.Height - a.Y), new Point(b.X, lb.Height - b.Y));
        }
        public static void SetColor(Bitmap lb, Color color)
        {
            for (int x = 0; x < lb.Width; x++)
                for (int y = 0; y < lb.Height; y++)
                    lb.SetPixel(x, y, color);
        }
        public static void DrawTriangle(LockBitmap lb, Triangle triangle)
        {
            Parallel.ForEach(triangle.Pixels, p =>
            {
                Color newColor = Utils.GetColorForPixel(triangle, p.Color, p.Pf);
                lb.SetPixel(p.X, lb.Height - p.Y, newColor);
            });
        }
        public static void ClearLB(LockBitmap lb)
        {
            for (int x = 0; x < lb.Width; x++)
                for (int y = 0; y < lb.Height; y++)
                    lb.SetPixel(x, y, Configuration.background.GetPixel(x,y));
        }
    }
}
