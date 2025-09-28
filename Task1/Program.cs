using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите температуру в °C:");
        string input = Console.ReadLine();

        double celsius;
        bool isSuccess = double.TryParse(input, out celsius);

        if (isSuccess)
        {
             double fahrenheit = (celsius * 9/5) + 32;
             Console.WriteLine($"{celsius}°C = {fahrenheit}°F");   
        }
        else
        {
            Console.WriteLine("Неверный формат");
        }
        
    }
}
