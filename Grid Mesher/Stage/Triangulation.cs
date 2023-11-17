using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Grid_Mesher.Stage
{
    public class Triangulation
    {
        public Triangle[] triangles;
        public Triangulation(int xTriCount, int yTriCount) 
        {
            int size = xTriCount * yTriCount * 2;
            if (size == 0)
            {
                triangles = new Triangle[0];
            }
            triangles = new Triangle[size];
            float xOff = Consts.XMax / xTriCount;
            float yOff = Consts.YMax / yTriCount;
            for(int i = 0; i < yTriCount; i++)
            {
                for (int j = 0; j < xTriCount; j++)
                {
                    triangles[i* xTriCount + j] = new Triangle() {
                        A = new Vector3(j * xOff, i * yOff, Utils.GetZ(j * xOff, i * yOff)),
                        B = new Vector3((j + 1) * xOff, i * yOff, Utils.GetZ((j + 1) * xOff, i * yOff)),
                        C = new Vector3((j + 1) * xOff, (i + 1) * yOff, Utils.GetZ((j + 1) * xOff, (i + 1) * yOff))
                    };
                    triangles[size / 2 + i * xTriCount + j] = new Triangle()
                    {
                        A = new Vector3(j * xOff, i * yOff, Utils.GetZ(j * xOff, i * yOff)),
                        B = new Vector3((j + 1) * xOff, (i + 1) * yOff, Utils.GetZ((j + 1) * xOff, (i + 1) * yOff)),
                        C = new Vector3(j * xOff, (i + 1) * yOff, Utils.GetZ(j * xOff, (i + 1) * yOff))
                    };
                }
            }
        }
        public void DrawGrid(LockBitmap lb)
        {
            foreach (var tri in triangles)
                tri.Draw(lb);
        }
    }
}
