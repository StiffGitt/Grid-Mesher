using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public static class Light
    {
        public static Vector3 Position { get; set; } = new Vector3(0.25f, 0.75f, 0.3f);
        public static float R { get; set; } = 0.5f;
        public static float Theta { get; set; } = 0f;
        public static bool IsInside { get; set; } = true;
        private const int LoopIterations = 100;
        private const float MaxR = 0.5f;

        public static void Animate()
        {
            PointF center = new PointF(Consts.XMax / 2, Consts.YMax / 2);
            float dtheta = (float)Math.PI / (LoopIterations / 4), r;
            float A = MaxR / LoopIterations;
            if (R - A < 0)
                IsInside = false;
            if (R + A > MaxR)
                IsInside = true;
            R = (IsInside) ? R - A : R + A;
            Theta = (IsInside) ? Theta + dtheta : Theta - dtheta;
            Position = new Vector3(center.X + R * (float)Math.Cos(Theta),center.Y + R * (float)Math.Sin(Theta), Position.Z);
        }
    }
}
