using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
                        Потрібно: Створити масив розмірністю N елементів, заповнити його довільними 
            цілими значеннями. Вивести найбільше значення масиву, найменше значення масиву, 
            загальну суму елементів, середнє арифметичне всіх елементів, вивести всі непарні значення.
             */

            int[] array = new int[6];

            List<int> unpaired = new List<int>();
                        
            Random random = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,99);
                
                if (array[i] % 2 != 0)
                {
                    unpaired.Add(array[i]);
                }

            }
            
            Console.WriteLine($"Array = {string.Join(", ", array)}");

            Console.WriteLine("Max value in array = {0}", array.Max());
            Console.WriteLine("Min value in array = {0}", array.Min());
            Console.WriteLine("Sum all elements in array = {0}", array.Sum());
            Console.WriteLine("Avarage of array = {0}", array.Average());
            Console.WriteLine($"Unpaired = {string.Join(", ", unpaired.ToArray())} ");

            Console.ReadKey();
        }
    }
}
