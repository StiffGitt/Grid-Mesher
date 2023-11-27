using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher
{
    public static class Configuration
    {
        public static Bitmap background { get; set; }
        public static Vector3[,] NormalMap {  get; set; }
        public static int XTriCount {get; set; }
        public static int YTriCount { get; set; }
        public static bool ShouldDrawGrid { get; set; }
        public static bool ShouldDrawBackground { get; set; }
        public static float Kd { get; set; } = 0.5f;
        public static float Ks { get; set; } = 0.5f;
        public static Vector3 Il { get; set; } = new Vector3(1, 1, 1);
        public static int M { get; set; } = 10;
        public static float[,] Z { get; set;} = new float[4, 4];
        public static bool ShouldAnimate { get; set; } = false;
        public static bool ShouldNormalMap { get; set; } = false;
        public static bool ShouldReplace { get; set; } = false;
        public static bool ShouldSphere { get; set; } = false;
    }
}
