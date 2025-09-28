using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        string[] splitWords = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int sentences = 0;
        foreach (char c in text)
        {
            if (c == '.' || c == '!' || c == '?')
                sentences++;
        }

        string[] words = new string[splitWords.Length];
        for (int i = 0; i < splitWords.Length; i++)
        {
            string w = splitWords[i].ToLower();
            w = w.Trim('.', ',', '!', '?', ';', ':', '"', '(', ')');
            words[i] = w;
        }

        string frequentWord = "";
        int maxCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < words.Length; j++)
            {
                if (words[i] == words[j])
                    count++;
            }
            if (count > maxCount)
            {
                maxCount = count;
                frequentWord = words[i];
            }
        }

        double totalLength = 0;
        foreach (string word in words)
        {
            totalLength += word.Length;
        }
        double averageLength = totalLength / words.Length;

        Console.WriteLine($"Количество слов: {words.Length}");
        Console.WriteLine($"Количество предложений: {sentences}");
        Console.WriteLine($"Самое частое слово встречается {maxCount} раз: {frequentWord}");
        Console.WriteLine($"Средняя длина слов: {averageLength}");
    }
}
