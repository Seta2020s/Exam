void ShowArray(string[] array)
{
    Console.WriteLine("Результат:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

string[] FilterArray(string[] inputArray)
{
    int count = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            inputArray[count] = inputArray[i];
            count++;
        }
    }

    string[] resultArray = new string[count];
    Array.Copy(inputArray, resultArray, count);

    return resultArray;
}

Console.WriteLine("Введите элементы массива (через запятую и пробел):");
string input = Console.ReadLine();

string[] inputArray = input.Split(new[] { ", " }, StringSplitOptions.None);

string[] resultArray = FilterArray(inputArray);

ShowArray(resultArray);