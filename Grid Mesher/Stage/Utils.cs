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
        public static Point ConvertToDrawingPoint(Vector3 v, LockBitmap lb)
        {
            int width = lb.Width - 1;
            int height = lb.Height - 1;
            int x = (int)(v[0] * width);
            int y = (int)(v[1] * height) + 1;
            return new Point(x, y);
        }
        public static float GetZ(float x, float y)
        {
            return FuncZ(x, y);
        }
        public static float GetCoeff(Point p1, Point p2)
        {
            Point a = (p1.X >= p2.X) ? p2 : p1;
            Point b= (p1.X >= p2.X) ? p1 : p2;
            return (float)(b.X - a.X) / (b.Y - a.Y);
        }
        private static int GetBinCoeff(int N, int K)
        {
            // Taken from:  http://blog.plover.com/math/choose.html
            int r = 1;
            int d;
            if (K > N) return 0;
            for (d = 1; d <= K; d++)
            {
                r *= N--;
                r /= d;
            }
            return r;
        }
        private static float FuncZ(float u, float v)
        {
            float z = 0;
            float Bu, Bv;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Bu = (float)(GetBinCoeff(3, i) * Math.Pow(u, i) * Math.Pow(1 - u, 3 - i));
                    Bv = (float)(GetBinCoeff(3, j) * Math.Pow(v, j) * Math.Pow(1 - v, 3 - j));
                    z += Configuration.Z[i, j] * Bu * Bv;
                }
            }
            return z;
        }
        public static Vector3 GetNormal(Vector3 P)
        {
            float h = Consts.eps;
            float zu = (FuncZ(P.X + h, P.Y) - FuncZ(P.X - h, P.Y)) / (2 * h);
            float zv = (FuncZ(P.X, P.Y + h) - FuncZ(P.X, P.Y - h)) / (2 * h);
            Vector3 Pu = new Vector3() {X = 1, Y = 0, Z = zu};
            Vector3 Pv = new Vector3() {X = 0, Y = 1, Z = zv};
            return Vector3.Normalize(Vector3.Cross(Pu, Pv));
        }

        public static Color GetColorForPixel(Triangle triangle, Color baseColor, PointF point)
        {
            var bar = triangle.GetBar(point);
            Vector3 P = new Vector3()
            {
                X = point.X,
                Y = point.Y,
                Z = bar.alfa * triangle.A.Z + bar.beta * triangle.B.Z + bar.gamma * triangle.C.Z
            };
            Vector3 N = triangle.Nt[0] * bar.alfa + triangle.Nt[1] * bar.beta + triangle.Nt[2] * bar.gamma;
            Vector3 L = Vector3.Normalize(Light.Position - P);
            Vector3 R = Vector3.Normalize((2 * Vector3.Dot(N, L) * N) - L);
            float cosNL = Vector3.Dot(N, L);
            float cosVR = Vector3.Dot(Consts.V, R);
            cosNL = cosNL < 0 ? 0 : cosNL;
            cosVR = cosVR < 0 ? 0 : cosVR;

            Vector3 I0 = Vector3FromRGB(baseColor);

            Vector3 I = Configuration.Kd * Configuration.Il * I0 * cosNL +
                Configuration.Ks * Configuration.Il * I0 * PowFloats(cosVR, Configuration.M);

            if (I.X > 1)
                I.X = 1;
            if (I.Y > 1)
                I.Y = 1;
            if (I.Z > 1)
                I.Z = 1;

            return Color.FromArgb((byte)(I.X * 255), (byte)(I.Y * 255), (byte)(I.Z * 255));
        }
        private static float PowFloats(float a, int b)
        {
            float pow = 1;
            for (int i = 0; i < b; i++) 
            {
                pow *= a;
            }
            return pow;
        }
        public static Vector3 Vector3FromRGB(Color color)
        {
            return new Vector3()
            {
                X = (float)color.R / 256,
                Y = (float)color.G / 256,
                Z = (float)color.B / 256,
            };
        }
    }
}
