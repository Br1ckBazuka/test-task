class MaxLength
{
    static void Main()
    {
            Console.WriteLine("Вставьте строку из .txt файла: ");
            var line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Введенная строка пустая");
                return;
            }
            string[] words = line.Split();
            var validWords = words
                .Where(word =>
                    word.Any(char.IsLetter)
                    && word.All(c => char.IsLetter(c) || c == '-' || c == '\'')
                )
                .ToArray();

            if (validWords.Length == 0)
            {
                Console.WriteLine("Строка содержит только цифры или символы");
                return;
            }

            if (words.Length != validWords.Length)
            {
                Console.WriteLine("Строка содержит цифры или символы");
            }
            // добавить проверку если самых длинных слов несколько
            var maxLength = validWords.Max(word => word.Length);
            var longWords = validWords.Where(word => word.Length == maxLength).ToArray();
            Console.WriteLine(
                longWords.Length == 1
                    ? $"Слово с максимальной длиной: {longWords[0]}"
                    : $"Слова с максимальной длиной ({maxLength}): {string.Join(",", longWords)}"
            );
    }
}
