using System;

namespace Homework5_3
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            /*
             Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного 
            розміру з можливістю зміни числа рядків і стовпців. Написати програму, яка виводить
            на екран матрицю і похідні від неї матриці різних порядків.
             */
               
            Matrix matrix = new Matrix(random.Next(3, 5), random.Next(3, 5));

            Console.WriteLine($"Matrix random size = {matrix.matrix.GetLength(0)} on {matrix.matrix.GetLength(1)}");

            matrix = FillMatrixRandom(matrix);
            FillMatrixRandom(matrix, true);

            Console.WriteLine(new string('-',50));

            
            matrix = matrix.ResizeArray(matrix, random.Next(3, 5), random.Next(3, 5));
               Console.WriteLine($"New resized matrix random size = {matrix.matrix.GetLength(0)} on {matrix.matrix.GetLength(1)}");

               //matrix = FillMatrixRandom(matrix);
               FillMatrixRandom(matrix, true);
            

            Console.ReadKey();

            

            
        }

        public static Matrix FillMatrixRandom(Matrix matrix , bool showMatrix = false)
        {
            for (int row = 0; row < matrix.matrix.GetLength(0); row++)
            {
                for (int columns = 0; columns < matrix.matrix.GetLength(1); columns++)
                {
                    if (showMatrix == false)
                    {
                        matrix.matrix[row, columns] = random.Next(0, 9);
                    }
                    else
                    {
                        Console.Write("{0} {1}", matrix.matrix[row, columns], columns==matrix.matrix.GetLength(1)-1?'\n':'|');
                    }
                    
                }
            }

            return matrix;
        }

        

    }
}
