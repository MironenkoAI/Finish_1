Console.WriteLine("Введите слова или символы через пробел:");
string? array = Console.ReadLine();

string[] miniWords = array.Split(' ');
Console.WriteLine("Массивы, длиной менее либо равно 3 символа: ");

for (int i = 0; i < miniWords.Length; i++)
{
    if (miniWords[i].Length < 4)
    {
        Console.Write($"[{miniWords[i]}] ");
    }
}