using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV03
{
    internal class Matrix
    {
        private double[,] matrix;
        public Matrix(double[,] _matrix)
        {
            matrix = _matrix;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if(a.matrix.GetLength(0)==b.matrix.GetLength(0) && a.matrix.GetLength(1)==b.matrix.GetLength(1))
            {
                double[,] outMatrix = new double[a.matrix.GetLength(0),a.matrix.GetLength(1)];
                for(int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        outMatrix[i,j] =a.matrix[i,j]+b.matrix[i,j];
                    }
                }
                return new Matrix(outMatrix);
            }
            else
            {
                throw new Exception("Incorrect matrix dimensions");
            }
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))
            {
                double[,] outMatrix = new double[a.matrix.GetLength(0), a.matrix.GetLength(1)];
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        outMatrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                    }
                }
                return new Matrix(outMatrix);
            }
            else
            {
                throw new Exception("Incorrect matrix dimensions");
            }
        }
        public static Matrix operator -(Matrix a)
        {
            double[,] outMatrix = new double[a.matrix.GetLength(0), a.matrix.GetLength(1)];
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    outMatrix[i, j] = -a.matrix[i, j];
                }
            }
            return new Matrix(outMatrix);
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if(a.matrix.GetLength(0)==b.matrix.GetLength(1))
            {
                double[,] outMatrix = new double[b.matrix.GetLength(0), a.matrix.GetLength(1)];
                for(int i = 0; i < outMatrix.GetLength(0);i++)
                {
                    for(int j = 0;j < outMatrix.GetLength(1);j++)
                    {
                        for(int k = 0;k<a.matrix.GetLength(1);k++)
                        outMatrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                    }
                }
                return new Matrix(outMatrix);
            }
            else
            {
                throw new Exception("Incorrect matrix dimensions");
            }
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            bool equals = false;
            if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))
            {
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        if (a.matrix[i, j] == b.matrix[i, j])
                            equals = true;
                        else
                            equals = false;
                    }
                }
                return equals;
            }
            else
            {
                throw new Exception("Incorrect matrix dimensions");
            }
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            bool equals = false;
            if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))
            {
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        if (a.matrix[i, j] != b.matrix[i, j])
                            equals = true;
                        else
                            equals = false;
                    }
                }
                return equals;
            }
            else
            {
                throw new Exception("Incorrect matrix dimensions");
            }
        }
        public static double determinant(Matrix a)
        {
            if(a.matrix.GetLength(0) == a.matrix.GetLength(1) && a.matrix.GetLength(0) <= 3)
            {
                double determinant = 0;
                switch (a.matrix.GetLength(0))
                {
                    case 1:
                        determinant = 1;
                        break;
                    case 2:
                        determinant = a.matrix[0, 0] * a.matrix[1, 1] - a.matrix[0, 1] * a.matrix[1, 0];
                        break;
                    case 3:
                        determinant = (a.matrix[0, 0] * a.matrix[1, 1] * a.matrix[2, 2]) + (a.matrix[0, 1] * a.matrix[1, 2] * a.matrix[2, 0]) + (a.matrix[0, 2] * a.matrix[1, 0] * a.matrix[2, 1]) - (a.matrix[0, 2] * a.matrix[1, 1] * a.matrix[2, 0]) - (a.matrix[0, 1] * a.matrix[1, 0] * a.matrix[2, 2]) - (a.matrix[0, 0] * a.matrix[1, 2] * a.matrix[2, 1]);
                        break;

                }
                return determinant;
            }
            elseb
            {
                throw new Exception("Incorrect matrix dimensions");
            }
        }
        public override String ToString()
        {
            string line = "";
            for (int i=0; i <matrix.GetLength(0);i++)
            {
                line += "|";
                for(int j = 0; j <matrix.GetLength(1);j++)
                {
                    line += String.Format("{0} ",matrix[i,j]);
                }
                line=line+"|\n";
            }
            return line;
        }
    } 
}

