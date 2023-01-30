using System;

namespace guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int guessNumber;
            int userGuess;
            int maxNumber;
            int attempts;

            Console.WriteLine("Играем в угадай число\nДля начала введите максимальное загадываемое число:");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            guessNumber = rand.Next(1, ++maxNumber);
            Console.WriteLine("\nТеперь введите максимальное число попыток:");
            attempts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nЯ загадал число, попробуйте его отгадать\n");

            while(attempts-- > 0)
            {
                Console.WriteLine($"Оставшееся количество попыток: {attempts + 1} \nВведите число:");
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (guessNumber == userGuess)
                {
                    Console.WriteLine("Поздравляю, вы угадали число");
                    break;
                }
                else if (guessNumber > userGuess)
                {
                    Console.WriteLine("загаданное число больше вашего\n");
                }
                else
                {
                    Console.WriteLine("загаданное число меньше вашего\n");
                }
            }
            if(attempts < 0)
            {
                Console.WriteLine("У вас закончились попытки и вы проиграли. Теперь я вас съем");
            }
        }
    }
}
