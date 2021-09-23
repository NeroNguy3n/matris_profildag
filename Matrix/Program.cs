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
             
            //2x2
            Matrix22 a = new Matrix22();
            a.elements[0, 0] = 1;
            a.elements[0, 1] = 2;
            a.elements[1, 0] = 3;
            a.elements[1, 1] = 4;
            Matrix22 b = new Matrix22();
            b.elements[0, 0] = 1;
            b.elements[0, 1] = 2;
            b.elements[1, 0] = 3;
            b.elements[1, 1] = 4;
            Matrix22 Addition = a.Add(b);
            Draw2x2Matrix(Addition.elements);
            Console.WriteLine("\n------------");
            Matrix22 Multiply = a.Multiply(b);
            Draw2x2Matrix(Multiply.elements);
            Console.WriteLine("\n------------");
            Console.WriteLine("Please type the degrees/angle");
            Matrix22 Rotation = a.CreateRotation();
            Draw2x2Matrix(Rotation.elements);
            Console.WriteLine("\n------------");
            Console.ReadKey();
            Console.Clear();

            //3x3
            Matrix22 a3 = new Matrix22();
            Matrix22 b3 = new Matrix22();
            a3.elements3[0, 0] = 1;
            a3.elements3[0, 1] = 2;
            a3.elements3[0, 2] = 3;
            a3.elements3[1, 0] = 1;
            a3.elements3[1, 1] = 2;
            a3.elements3[1, 2] = 3;
            a3.elements3[2, 0] = 1;
            a3.elements3[2, 1] = 2;
            a3.elements3[2, 2] = 3;

            b3.elements3[0, 0] = 1;
            b3.elements3[0, 1] = 2;
            b3.elements3[0, 2] = 3;
            b3.elements3[1, 0] = 1;
            b3.elements3[1, 1] = 2;
            b3.elements3[1, 2] = 3;
            b3.elements3[2, 0] = 1;
            b3.elements3[2, 1] = 2;
            b3.elements3[2, 2] = 3;

            Matrix22 Addition3 = a3.Add(b3);
            Draw3x3ResultMatrix(Addition3.elements3);
            Console.WriteLine("\n------------------------");
            Matrix22 Multiply3 = a3.Multiply(b3);
            Draw3x3ResultMatrix(Multiply3.elements3);
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Please type the degrees/angle");
            Matrix22 Rotation3 = a3.CreateRotation();
            Draw3x3ResultMatrix(Rotation3.elements3);
            Console.ReadKey();
        }
    }
}
