using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        Console.WriteLine("Загадано число от 1 до 10.");

        while (true)
        {
            Console.Write("Введите число:");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int userNumber))
            {
                
                if (userNumber == randomNumber)
                {
                    Console.WriteLine("Число отгадано");
                    break;
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine("Число больше");
                }
                else
                {
                    Console.WriteLine("Число меньше");
                }
            }
            else
            {
                Console.WriteLine("Неверный формат");
            }
        }
    }
}
