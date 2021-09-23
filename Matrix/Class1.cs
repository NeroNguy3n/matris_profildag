using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixChecker
    {
        public static float[,] CheckAddition(float[,] e, float[,] m)
        {
            float[,] emA = new float[2, 2];
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 2; x++)
                {
                    emA[y, x] = e[y, x] + m[y, x];
                }
            }
            return emA;
        }

        public static float[,] CheckMultiplikation(float[,] e, float[,] matrix)
        {
            float[,] emM = new float[2, 2];
            return emM;
        }
        public static float[,] CheckRotationMatrix(float[,] e, float[,] matrix)
        {
            float[,] emR = new float[2, 2];
            return emR;
        }
    }
}
