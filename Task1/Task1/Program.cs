class MaxLength
{
    static void Main()
    {
        var filePath = "../../../test.txt";
        var line = File.ReadAllText(filePath);

        if (string.IsNullOrWhiteSpace(line))
        {
            Console.WriteLine("Строка пустая");
            return;
        }

        string[] words = line.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries
        );

        var letter = words.Where(word => word.All(char.IsLetter)).ToArray();

        if (letter.Length == 0)
        {
            Console.WriteLine("Строка содержит только символы и цифры");
            return;
        }

        var longWord = letter.MaxBy(word => word.Length);
        Console.WriteLine($"Самое длинное слово: {longWord}");
    }
}

