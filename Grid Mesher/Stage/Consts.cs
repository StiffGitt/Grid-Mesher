using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public class Consts
    {
        public const float XMax = 1;
        public const float YMax = 1;
        public const float eps = 0.000001f;
        public const float ZMax = 1;
        public const float A = 0.01f;
        public static readonly Vector3 V = Vector3.UnitZ;
        public static Color firstColor = Color.Goldenrod;
        public static Color BackColor;
    }
}
