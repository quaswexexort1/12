
        string zashifrovan = "olleH dlroW olleH avcds";

        string razshifrovan = Decrypt(zashifrovan);

        Console.WriteLine($"Зашифрованное сообщение: {zashifrovan}");
        Console.WriteLine($"Расшифрованное сообщение: {razshifrovan}");



static string Decrypt(string message)
{
    return string.Join(" ", message.Split(' ').Select(word => new string(word.Reverse().ToArray())));
}

