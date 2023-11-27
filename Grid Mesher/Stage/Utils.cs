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
        public static Point ConvertToDrawingPoint(Vector3 v)
        {
            int width = Configuration.background.Width - 1;
            int height = Configuration.background.Height - 1;
            int x = (int)(v[0] * width);
            int y = (int)(v[1] * height) + 1;
            return new Point(x, y);
        }
        private static float GetZFromSphere(float x, float y)
        {
            float R = Consts.R;
            float X = Consts.SC.X;
            float Y = Consts.SC.Y;
            if (Math.Sqrt((x - X) * (x - X) + (y - Y) * (y - Y)) > R)
                return 0f;
            return (float)Math.Sqrt(Math.Abs(R * R - (x - X) * (x - X) - (y - Y) * (y - Y)));
        }
        public static float GetZ(float x, float y)
        {
            if (Configuration.ShouldSphere)
                return GetZFromSphere(x, y);
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
        private static Vector3 GetNormalFromSphere(Vector3 P)
        {
            //if (Math.Sqrt((P.X - Consts.SC.X) * (P.X - Consts.SC.X) + (P.Y - Consts.SC.Y) * (P.Y - Consts.SC.Y)) > Consts.R)
            //    return new Vector3(0, 0, 1);
            Vector3 O = Consts.SC;
            Vector3 V = Vector3.Normalize(P - O);
            return V;
        }
        public static Vector3 GetNormal(Vector3 P)
        {
            if (Configuration.ShouldSphere)
                return GetNormalFromSphere(P);
            float h = Consts.eps;
            float zu = (FuncZ(P.X + h, P.Y) - FuncZ(P.X - h, P.Y)) / (2 * h);
            float zv = (FuncZ(P.X, P.Y + h) - FuncZ(P.X, P.Y - h)) / (2 * h);
            Vector3 Pu = new Vector3() {X = 1, Y = 0, Z = zu};
            Vector3 Pv = new Vector3() {X = 0, Y = 1, Z = zv};
            return Vector3.Normalize(Vector3.Cross(Pu, Pv));
        }
        private static Vector3 ModifyByNormal(Vector3 Np, int X, int Y)
        {
            if (X >= Configuration.NormalMap.GetLength(0) || Y >= Configuration.NormalMap.GetLength(1))
                return Np;
            
            Vector3 Nt = Configuration.NormalMap[X, Y];
            if (Configuration.ShouldReplace)
                return Nt;

            Vector3 B = Vector3.Cross(Np, Vector3.UnitZ);
            Vector3 T = Vector3.Cross(B, Np);
            Matrix3 M = new Matrix3(T, B, Np);
            return M.Transform(Nt);
        }

        public static Color GetColorForPixel(Triangle triangle, Pixel p)
        {
            Color baseColor = p.Color;
            Vector3 P = p.P;
            Vector3 N = p.N;
            //if (Math.Sqrt((P.X - Consts.SC.X) * (P.X - Consts.SC.X) + (P.Y - Consts.SC.Y) * (P.Y - Consts.SC.Y)) > Consts.R)
            //    N = new Vector3(0, 0, 1);
            if (Configuration.ShouldNormalMap)
                N = ModifyByNormal(N, p.X, p.Y);
            Vector3 L = Vector3.Normalize(Light.Position - P);
            Vector3 R = Vector3.Normalize((2 * Vector3.Dot(N, L) * N) - L);
            float cosNL = Vector3.Dot(N, L);
            float cosVR = Vector3.Dot(Consts.V, R);
            cosNL = cosNL < 0 ? 0 : cosNL;
            cosVR = cosVR < 0 ? 0 : cosVR;

            Vector3 I0 = Vector3.Normalize(Vector3FromRGB(baseColor));

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
                X = (float)color.R / 255,
                Y = (float)color.G / 255,
                Z = (float)color.B / 255,
            };
        }
        public static void MakeNormalMap(Bitmap bt)
        {
            Vector3[,] map = new Vector3[bt.Width, bt.Height];
            for (int x = 0; x < bt.Width; x++)
            {
                for(int y = 0; y < bt.Height; y++)
                {
                    map[x, y] = Vector3.Normalize(Vector3FromRGB(bt.GetPixel(x, bt.Height - y - 1)));
                }
            }
            Configuration.NormalMap = map;
        }
    }
}
