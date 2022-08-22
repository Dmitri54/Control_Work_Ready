
Console.WriteLine("Программа выведет на экран только слова состоящии из трех и менее букв.");

string[] arrayOfStrings = new string[] { };

int n = InputNumbers("Введите количество элементов массива: ");
arrayOfStrings = new string[n];
for (int i = 0; i < arrayOfStrings.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    arrayOfStrings[i] = Console.ReadLine();
}

int lengthLimit = 3;

int numbersItems = CheckArray(arrayOfStrings, lengthLimit);

string[] newArrayOfStrings = new string[numbersItems];

int CheckArray(string[] array, int lengthLimit) // Метод подсчёта количества элементов, длина которых меньше или равна 3 символа.
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

int InputNumbers(string input) // Метод, пользователь задает количество элементов в новом массиве
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}



