
Console.WriteLine("Программа выведет на экран только слова состоящии из трех и менее букв.");

string[] arrayOfStrings = new string[] { };

int n = InputNumbers("Введите количество элементов массива: ");
arrayOfStrings = new string[n];
for (int i = 0; i < arrayOfStrings.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    arrayOfStrings[i] = Console.ReadLine();
}

int InputNumbers(string input) // Метод, пользователь задает количество элементов в новом массиве
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

