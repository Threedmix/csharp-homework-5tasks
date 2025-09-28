using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите пароль:");
        string password = Console.ReadLine();

        bool errors = false;
        
        if (password.Length < 8)
        {
            Console.WriteLine("Длина меньше 8 символов");
            errors = true;
        }

        int countDigit = 0;
        int countUpper = 0;
        int countSymbol = 0;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                countDigit += 1;
            }
            if (char.IsUpper(c))
            {
                countUpper += 1;
            }
            if ("!@#$%^&*".Contains(c))
            {
                countSymbol += 1;
            }
        }

        if (countDigit == 0)
        {
            Console.WriteLine("Нет цифр");
            errors = true;
        }
        
        if (countUpper == 0)
        {
            Console.WriteLine("Нет заглавных букв");
            errors = true;
        }
        
        if (countSymbol == 0)
        {
            Console.WriteLine("Нет специальных символов !@#$%^&*");
            errors = true;
        }

        if (errors == false)
        {
            Console.WriteLine("Пароль надежный");
        }    
    }
}    
