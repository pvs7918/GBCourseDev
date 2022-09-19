/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []
*/

string[] ResizeArray(string[] srcArray, int newSize)
{
    string[] resArray = new string[newSize];
    for (int i = 0; i < newSize; i++)
    {
        if (i >= srcArray.Length)
            resArray[i] = "";
        else
            resArray[i] = srcArray[i];
    }
    return resArray;
}

bool InputStringArray(ref string[] srcArray)
{
    string srcString = string.Empty;
    int N = -1;
    while (true)
    {
        Console.WriteLine($"Введите {N + 1}-ю строку текста для исходного массива строк. Нажмите q для окончания ввода.");
        srcString=Console.ReadLine();
        if (srcString.ToUpper() == "Q")
        {
            break;
        }
        else
        {
            N++;
            srcArray = ResizeArray(srcArray, N+1);
            srcArray[N] = srcString;
        }
    }

    if (N < 0)
        return false;
    else
        return true;
}

string OutputStringArray(string[] srcArray)
{
    string str = "[";
    for (int i = 0; i < srcArray.Length; i++)
    {
        if (i > 0)
            str += ", ";
        str += $"\"{srcArray[i]}\"";
    }
    str += "]";
    return str;
}

string[] Array1 = new string[1] { "" };
int j = -1;
string[] Array2 = new string[1] { "" };

if (InputStringArray(ref Array1))
{
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3)
        {
            j++;
            Array2 = ResizeArray(Array2, j + 1);
            Array2[j] = Array1[i];
        }
    }
    Console.WriteLine($"{OutputStringArray(Array1)} -> {OutputStringArray(Array2)}");
}
else
{
    Console.WriteLine("Исходный массив не введен! Выполнение программы прервано!");
}