using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            float[,] e = new float[2, 2];
            e[0, 0] = 1;
            e[0, 1] = 1;
            e[1, 0] = 1;
            e[1, 1] = 1;
            float[,] m = new float[2, 2];
            m[0, 0] = 1;
            m[0, 1] = 1;
            m[1, 0] = 1;
            m[1, 1] = 1;
            float[,] emA = MatrixChecker.CheckAddition(e, m);

            Draw2x2Matrix(emA[0, 0], emA[0,1], emA[1,0], emA[1,1]);



            Console.ReadKey();
        }
    }
}
