using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public struct Matrix3
    {
        float[,] M {  get; set; }

        public Matrix3(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            M = new float[3, 3];
            M[0, 0] = v1.X;
            M[1, 0] = v1.Y;
            M[2, 0] = v1.Z;

            M[0, 1] = v2.X;
            M[1, 1] = v2.Y;
            M[2, 1] = v2.Z;

            M[0, 2] = v3.X;
            M[1, 2] = v3.Y;
            M[2, 2] = v3.Z;
        }
        public Vector3 Transform(Vector3 v)
        {
            float X = v.X * M[0, 0] + v.Y * M[0, 1] + v.Z * M[0, 2];
            float Y = v.X * M[1, 0] + v.Y * M[1, 1] + v.Z * M[1, 2];
            float Z = v.X * M[2, 0] + v.Y * M[2, 1] + v.Z * M[2, 2];
            return new Vector3(X, Y, Z);
        }
    }
}
