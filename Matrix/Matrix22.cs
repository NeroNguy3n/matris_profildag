using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix22
    {
        public float[,] elements = new float[2, 2];
        public float[,] elements3 = new float[3, 3];
        public Matrix22 Add(Matrix22 b) 
        {

            Matrix22 result = new Matrix22();
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 2; x++)
                {
                    result.elements[y, x] = this.elements[y, x] + b.elements[y, x];
                }
            }
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    result.elements3[y, x] = this.elements3[y, x] + b.elements3[y, x];
  
                }
            }
            return result;
        }
        public Matrix22 Multiply(Matrix22 b) 
        {
            Matrix22 result = new Matrix22();
            for (int y = 0; y < 2; y++)
            {
                result.elements[y, 0] = (this.elements[y, 0] * b.elements[0, 0]) + (this.elements[y, 1] * b.elements[1, 0]);
                result.elements[y, 1] = (this.elements[y, 0] * b.elements[0, 1]) + (this.elements[y, 1] * b.elements[1, 1]);
            }
            for (int y = 0; y < 3; y++)
            {
                result.elements3[y, 0] = (this.elements3[y, 0] * b.elements3[0, 0]) + (this.elements3[y, 1] * b.elements3[1, 0]) + (this.elements3[y, 2] * b.elements3[2,0]);
                result.elements3[y, 1] = (this.elements3[y, 0] * b.elements3[0, 1]) + (this.elements3[y, 1] * b.elements3[1, 1]) + (this.elements3[y, 2] * b.elements3[2, 1]);
                result.elements3[y, 2] = (this.elements3[y, 0] * b.elements3[0, 2]) + (this.elements3[y, 1] * b.elements3[1, 2]) + (this.elements3[y, 2] * b.elements3[2, 2]);
            }
            return result;
        }
        public Matrix22 CreateRotation() 
        {
            Matrix22 result = new Matrix22();
            double angle;
            angle = Convert.ToDouble(Console.ReadLine());

            double radians = angle * (Math.PI / 180);
            result.elements[0, 0] = (float)Math.Cos(radians);
            result.elements[0, 1] = (float)Math.Sin(radians);
            result.elements[1, 0] = -(float)Math.Sin(radians);
            result.elements[1, 1] = (float)Math.Cos(radians);

            //z
            result.elements3[0, 0] = (float)Math.Cos(radians);
            result.elements3[0, 1] = (float)Math.Sin(radians);
            result.elements3[0, 2] = 0;

            result.elements3[1, 0] = -(float)Math.Sin(radians);
            result.elements3[1, 1] = (float)Math.Cos(radians);
            result.elements3[1, 2] = 0;

            result.elements3[2, 0] = 0;
            result.elements3[2, 1] = 0;
            result.elements3[2, 2] = 1;
            //y
            result.elements3[0, 0] = (float)Math.Cos(radians);
            result.elements3[0, 1] = 0;
            result.elements3[0, 2] = -(float)Math.Sin(radians);

            result.elements3[1, 0] = 0;
            result.elements3[1, 1] = 1;
            result.elements3[1, 2] = 0;

            result.elements3[2, 0] = -(float)Math.Sin(radians);
            result.elements3[2, 1] = 0;
            result.elements3[2, 2] = (float)Math.Cos(radians);
            //x
            result.elements3[0, 0] = 1;
            result.elements3[0, 1] = 0;
            result.elements3[0, 2] = 0;

            result.elements3[1, 0] = 0;
            result.elements3[1, 1] = (float)Math.Cos(radians);
            result.elements3[1, 2] = (float)Math.Sin(radians);

            result.elements3[2, 0] = 0;
            result.elements3[2, 1] = -(float)Math.Sin(radians);
            result.elements3[2, 2] = (float)Math.Cos(radians);
            return result;
        }
    }
}
