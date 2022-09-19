/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string [] InputStringArray()
{
    string [] srcArray;
    string srcString = string.Empty;
    int N = 0;
    while (true)
    {
        Console.WriteLine($"Введите {N}-ю строку текста для исходного массива строк. Нажмите q для окончания ввода.");
        srcString = Console.ReadLine();
        if (srcString.ToUpper() == "Q")
        {
            break;
        }
        else
        {
            N++;
            Array.Resize(ref srcArray, N);
            srcArray[N]=srcString;
        }
    }
    return srcArray;
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
