using System;
using System.Linq;

namespace Homework5_6
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            string[] languages = { "ua", "eng", "ru" };

            int[] positions;
            string userInput;

            string[,] vocab = 
            {  
                { "сонце", "sun", "солнце" } , 
                { "вітер", "wind", "ветер" }, 
                { "хмара", "cloud", "туча" }, 
                { "дощ", "rain", "дождь" },
                { "сніг", "snow", "снег"},
                { "блискавка", "lightning", "молния"},
                { "спека", "Heat", "жара"},
                { "холод", "Cold", "холод"},
                { "температура", "temperature", "температцра"},
                { "туман", "fog", "туман"}
            };


            do
            {
                showVocab(vocab);
                Console.WriteLine("Enter a word (or type 'e' for exit):");

                userInput = Console.ReadLine().ToLower();

                positions = searchWords(vocab, userInput);

                if ((positions[0] + positions[1]) != -2)
                {
                    for (int j = 0; j < vocab.GetLength(1); j++)
                    {
                        if (j != positions[1])
                        {
                            Console.WriteLine($"Languge = {languages[j]} word = {vocab[positions[0], j]}");
                        }

                    }
                }
                else if(userInput != "e")
                {
                    Console.WriteLine("Not found, try againe");
                }



            } while (userInput != "e");

            


        }

        public static void showVocab(string[,] vocab)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Words in Interpreter:");
            for (int i = 0; i < vocab.GetLength(0); i++)
            {
                Console.WriteLine( $"{vocab[i, 0]} | {vocab[i, 1]} | {vocab[i, 2]}"  );
            }
            Console.ResetColor();
        }


        static int[] searchWords(string[,] vocab, string userInput)
        {
            int[] positions = { -1 , -1};

            for (int i = 0; i < vocab.GetLength(0); i++)
            {
                for (int j = 0; j < vocab.GetLength(1); j++)
                {
                    if (vocab[i, j].ToLower() == userInput.ToLower())
                    {
                        positions[0] = i;
                        positions[1] = j;
                    }

                }
            }

            return positions;

        }

    }
}
