using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            string task = "Что в огне не горит и в воде не тонет?";
            string answer = "Лёд";
            int tryCount = 5;

            Console.WriteLine("Привет, давай сыграем в игру!\nОтгадай мою загадку! :-)");
            Console.WriteLine(task);
            Console.WriteLine("У тебя 5 попыток! Дерзай детка!"); 
            for(int i = 0; i < 5; i++)
            {
                string inputedWord = Console.ReadLine().ToLower();
                if(inputedWord == answer.ToLower())
                    break;
                else
                {
                    Console.WriteLine($"У вас осталось {--tryCount} попыток!");
                    continue;                
                }
            }
            if(tryCount == 0)
                Console.WriteLine("Ты проиграл");
            else
                Console.WriteLine("Победа");        
        }
    }
}
