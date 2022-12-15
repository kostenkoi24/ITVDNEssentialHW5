using System;

namespace Homework5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /*
             
             Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас Article, що містить наступні закриті поля:
            • Назва товару;
            • назва магазину, в якому продається товар;
            • вартість товару в гривнях. Створити клас Store, який містить закритий масив елементів типу Article.
            Забезпечити такі можливості:
            • висновок інформації про товар за номером за допомогою індексу;
            • висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких
            товарів немає, видати відповідне повідомлення.
            Написати програму, виведення на екран інформацію про товар.
             
             */

            Article article1 = new Article("Jacket", "Adidas", 5000);
            Article article2 = new Article("Sneakers", "Puma", 2500);
            Article article3 = new Article("T-shirt", "UnderArmor", 999);

            Store store = new Store(article1, article2, article3);

            string userInput = "";
            do
            {
                Console.WriteLine("Info:"); 

                for (int i = 0; i < 3; i++)
                {
                    Print(store, i);
                }

                Console.Write("Enter index or product name for search (type 'e' for exit): ");
                userInput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                int index;
                if (int.TryParse(userInput, out index) == true)
                {
                    
                    Console.WriteLine($"Searching product by index = {userInput}");
                    Print(store, index-1);
                    
                }
                else if (userInput.ToLower() != "e")
                {
                    Console.WriteLine($"Searching product by name = {userInput}");
                    SearchProduct(store, userInput);
                }
                Console.ResetColor();

            } while (userInput.ToLower() != "e");




            Console.WriteLine("bay bay!");
            Console.ReadKey();


        }


        public static void SearchProduct(Store store, string s)
        {
            bool search = false;
            for (int i = 0; i < 3; i++)
            {
                if (store[i].ProductName.ToLower() == s.ToLower())
                {
                    Print(store, i);
                    search = true;
                }
            }

            if (search == false)
            {
                Console.WriteLine($"product by name = {s} not found");
            }
        }


        public static void Print(Store store, int i)
        {
            Console.WriteLine($"{i + 1}. Shop = {store[i].ShopName} | ProductName = {store[i].ProductName} | Cost = {store[i].ProductCoast}");
        }

    }
}
