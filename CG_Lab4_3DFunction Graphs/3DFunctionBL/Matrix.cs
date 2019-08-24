using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFunctionBL
{
    public class Matrix
    {
        double[,] matrix;
        public Matrix()
        {
            matrix = new double[4, 4];
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                    if (row == column)
                        matrix[row, column] = 1.0;
                    else
                        matrix[row, column] = 0.0;
        }
        public Matrix(double [,] m)
        {
            matrix = m;
        }
        public double this[int row, int column]
        {
            get
            {
                return matrix[row, column];

            }
            set
            {
                matrix[row, column] = value;
            }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix output = new Matrix();
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                    output[row, column] = a[row, column] + b[row, column];
            return output;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix output = new Matrix();
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                    output[row, column] = a[row, column] - b[row, column];
            return output;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix output = new Matrix();
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                {
                    output[row, column] = 0;
                    for (int i = 0; i < 4; i++)
                        output[row, column] += a[row, i] * b[i, column];
                }
            return output;
        }
        public static Vector operator *(Matrix a, Vector v) 
        {
            Vector output = new Vector();
            output.X = v.X * a[0, 0] + v.Y * a[0, 1] + v.Z * a[0, 2] /*+ v.w * a[0, 3]*/;
            output.Y = v.X * a[1, 0] + v.Y * a[1, 1] + v.Z * a[1, 2] /*+ v.w * a[1, 3]*/;
            output.Z = v.X * a[2, 0] + v.Y * a[2, 1] + v.Z * a[2, 2] /*+ v.w * a[2, 3]*/;
            //output.w = v.X * a[3, 0] + v.Y * a[3, 1] + v.Z * a[3, 2] /*+ v.w * a[3, 3]*/;
            return output;
        }
     
       
        public static Matrix One()
        {
            return new Matrix(new double[,]
            {
                { 1,0,0,0},
                { 0,1,0,0},
                { 0,0,1,0},
                { 0,0,0,1}
            });
        }
        public static Matrix Rotate(int ia, float angle)
        {
            int a1 = (ia + 1) % 3;
            int a2 = (ia + 2) % 3;
            Matrix m = Matrix.One();
            m[a1, a1] = (float)Math.Cos(angle);
            m[a1, a2] = (float)-Math.Sin(angle);
            m[a2, a1] = (float)Math.Sin(angle);
            m[a2, a2] = (float)Math.Cos(angle);
            return m;
        }
    }
}
