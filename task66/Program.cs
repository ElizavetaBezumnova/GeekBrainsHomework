/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

System.Console.Write("Введите число M:");
int M = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите число N:");
int N = int.Parse(Console.ReadLine()!);

int SumMN(int start, int end)
{
    if (start==end)
    {
        return start;
    }
    else
    {
        int sum = start + SumMN(start+1, end);
        return sum;
    }

}

System.Console.WriteLine(SumMN(M,N));
