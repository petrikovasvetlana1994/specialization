/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма*/

string[] array = {"hello", "2", "world", ":-)", "OK"};

void PrintArrayStr(string[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
}

string[] ChangeArray(string[] array)
{
    var resultArray = new string[array.Length];
    var realSize = 0;
    foreach (var value in array)
    {
        if (value.Length <= 3)
        {
            resultArray[realSize] = value;
            realSize++;
        }
    }
    return resultArray;
}

PrintArrayStr(array);
Console.WriteLine();
PrintArrayStr(ChangeArray(array));
Console.WriteLine();
	