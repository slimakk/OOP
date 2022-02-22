using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] data1 = new double[,]
            {
                {1,0,5 },
                {2,8,10 },
                {3,9,11},
            };
            double[,] data2 = new double[,]
            {
                {1,26,5 },
                {7,2,10 },
                {11,5,1},
            };
            Matrix matrix=new Matrix(data1);
            Matrix matrix1 = new Matrix(data2);
            Console.WriteLine("First matrix");
            Console.WriteLine(matrix);
            Console.WriteLine("Second matrix");
            Console.WriteLine(matrix1);
            Console.WriteLine("Addition");
            Console.WriteLine(matrix + matrix1);
            Console.WriteLine("Subtraction");
            Console.WriteLine(matrix - matrix1);
            Console.WriteLine("Negation");
            Console.WriteLine(-matrix);
            Console.WriteLine("Multiplication");
            Console.WriteLine(matrix * matrix1);
            Console.WriteLine("Equal");
            Console.WriteLine(matrix == matrix1);
            Console.WriteLine("Not equal");
            Console.WriteLine(matrix != matrix1);
            Console.WriteLine("Determinant");
            Console.WriteLine(Matrix.determinant(matrix));
            Console.ReadLine();
        }
    }
}
