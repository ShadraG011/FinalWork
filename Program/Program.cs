Console.Clear();
Console.Write("Введите количество элементов для ввода: ");
int sizeFirstArray = Convert.ToInt32(Console.ReadLine());
string?[] wordArray = new string[sizeFirstArray];
int sizeSecondArray = 0;

for (int i = 0; i < sizeFirstArray; i++)
{
    Console.Write($"Введите {i + 1} слово: ");
    wordArray[i] = Console.ReadLine();
    if (wordArray[i]?.Length <= 3) sizeSecondArray++;
}

string?[] resultWordArray = new string[sizeSecondArray];
int j = 0;
for (int i = 0; i < sizeFirstArray; i++)
{
    if (wordArray[i]?.Length <= 3) 
    {
        resultWordArray[j] = wordArray[i];
        j++;
    }
}
Console.WriteLine($"Элементы с количеством символов меньше, либо равные 3-м: [{String.Join(", ", resultWordArray)}]");