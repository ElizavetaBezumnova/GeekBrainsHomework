/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

System.Console.Write("Введите число N:");
int N = int.Parse(Console.ReadLine()!);

string NaturalNReverse(int end, int start)
{
    if (end == start)
    {
        return end.ToString();
    }
    return (end+" "+NaturalNReverse(end-1,start));

}

System.Console.WriteLine(NaturalNReverse(N,1));