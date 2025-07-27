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
            var hasSymbolsOrNumber = words.Any(word => word.Any(c=> !char.IsLetter(c)));
            if (hasSymbolsOrNumber)
            {
                Console.WriteLine("Строка содержит символы или цифры");
                return;
            }
            var longWord = words.OrderByDescending(word => word.Length).First();
            Console.WriteLine($"Самое длинное слово: {longWord}");

                            //Обработка случаев для слов с " - " и " ' "
            // var validWords = words
            //     .Where(word =>
            //         word.Any(char.IsLetter)
            //         && word.All(c => char.IsLetter(c) || c == '-' || c == '\'')
            //     )
            //     .ToArray();

            // if (validWords.Length == 0)
            // {
            //     Console.WriteLine("Строка содержит только цифры или символы");
            //     return;
            // }
            
                            //Обработка случаев если самых длинных слов несколько
            // var maxLength = words.Max(word => word.Length);
            // var longWords = words.Where(word => word.Length == maxLength).ToArray();
            // Console.WriteLine(
            //     longWords.Length == 1
            //         ? $"Слово с максимальной длиной: {longWords[0]}"
            //         : $"Слова с максимальной длиной ({maxLength}): {string.Join(",", longWords)}"
            // );
    }
}
