using System;

class Program
{
    static void Main()
    {
        double sum = 0;
        
        while (true)
        {
            Console.Write("Введите число:");
            string input = Console.ReadLine();

            double number;
            bool isSuccess = double.TryParse(input, out number);

            if (isSuccess)
            {
                if (number != 0)
                {
                    sum += number;
                    Console.WriteLine($"Сумма: {sum}");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Неверный формат");
            }
            
        }

        
    }
}
