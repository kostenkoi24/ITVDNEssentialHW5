using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_3
{
    class Matrix
    {

        public int[,] matrix;
        

        public Matrix(int rows, int columns)
        {
            this.matrix = new int[rows, columns];
        }


        public Matrix ResizeArray(Matrix matrix ,int rows, int columns)
        {
            int newArraySize = rows * columns;
            int oldArraySize = matrix.matrix.GetLength(0) * matrix.matrix.GetLength(1);
            var select = "y";


            if (newArraySize < oldArraySize)
            {
                Console.Write("Array will be truncated! To continue press Y or N for return: ");
                select = Console.ReadLine().ToLower();
            }

            
            if (select == "y")
            {

                Matrix newMatrix = new Matrix(rows, columns);
                
                if (newArraySize < oldArraySize)
                {
                    Array.Copy(matrix.matrix, newMatrix.matrix, newArraySize);
                }
                else
                {
                    Array.Copy(matrix.matrix, newMatrix.matrix, oldArraySize);
                }

                
                
                return newMatrix;
            }
            else
            {
                return matrix;
            }



        }

       

    }
}
