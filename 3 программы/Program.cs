using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            Console.Write("Введите число: ");

            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                GuessNumberGame();
                break;
            }
            else if (choice == 2)
            {
                MultiplicationTable();
                break;
            }
            else if (choice == 3)
            {
                PrintDivisors();
                break;
            }
            else if (choice == 4)
            {
                Console.Write("Выход Из Программы");
                break;
            }

        }
        static void GuessNumberGame()
        {
            Random random = new();
            int randomNumber = random.Next(0, 101);

            Console.WriteLine("Игра 'Угадай число'");
            Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте угадать!");

            int guessedNumber = -1;

            while (guessedNumber != randomNumber)
            {
                Console.Write("Введите число: ");
                guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
            }

            Console.WriteLine("Поздравляю! Вы угадали число!");
        }

        static void MultiplicationTable()
        {
            int[,] table = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            Console.WriteLine("Таблица умножения 10 на 10:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintDivisors()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Делители числа " + number + ": ");

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}