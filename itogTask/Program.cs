/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
 длина которых меньше или равна 3 символа */

string[] beforeArray = new string[] { "hello", "2", "world", ":-)"};
string[] afterArray = new string[beforeArray.Length];
int j = 0;

for (int i = 0; i < beforeArray.Length; i++)
{
    if (beforeArray[i].Length >=3)
    {
        afterArray[j] = beforeArray[i];
        j++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(afterArray);