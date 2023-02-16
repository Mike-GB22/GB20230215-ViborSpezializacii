// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine("\n"
    + "Задача. "
    + "Из первоночального массива строк выбрть все элементы, "
    + "длина строк которых меньше или равна 3.\n"
    + "Первоначальный массив задать с клавиатуры на старне выполнения.\n"
    + "\nПример: "
    + "[один, два, три, четыре, пять] -> [два, три].\n");

int ReadKeyboardInt(string prompt)
{
    System.Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReadKeyboardString(string prompt)
{
    System.Console.Write(prompt + ": ");
    return (Console.ReadLine() ?? "0");
}
string[] MakeAnArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadKeyboardString($"Введите строку {i}");
    }
    return array;
}

bool WhatWeNeed(string text)
{
    //System.Console.WriteLine(text+"---"+text.Length);
    if (text.Length > 3) return false;
    return true;
}

int SearchNeedfulElements(string[] arrayOrigin, string[] arrayNew)
{
    int countWhatWeNeed = 0;
    for (int i = 0; i < arrayOrigin.Length; i++)
    {
        if (WhatWeNeed(arrayOrigin[i]))
        {
            arrayNew[countWhatWeNeed] = arrayOrigin[i];
            countWhatWeNeed++;

        }
    }
    return countWhatWeNeed;
}
string[] CropArray(string[] arrayIn, int length)
{
    string[] arrayNew = new string[length];
    for (int i = 0; i < length; i++)
    {
        arrayNew[i] = arrayIn[i];
    }
    return arrayNew;
}

void PrintArray(string prompt, string[] array)
{
    System.Console.Write(prompt + ": [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.WriteLine(array[array.Length - 1] + "]");
}

void PrintString(string prompt, string text)
{
    System.Console.Write(prompt + ": " + text);
}

string[] array = MakeAnArray(ReadKeyboardInt("Введите количество строк в новом массиве"));
PrintArray("\nОригинальный массив", array);

string[] newArray = new string[array.Length];
int countWhatWeNeed = SearchNeedfulElements(array, newArray);
PrintArray($"Выборка из {countWhatWeNeed} элементов", newArray);

newArray = CropArray(newArray, countWhatWeNeed);
PrintArray($"\nОбрезаем массив, получаем итоговый ответ на задачу", newArray);