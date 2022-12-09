// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine());
int count = 0;
int b = a;
while (b>0)
{
    count = count + 1;
    b = b / 10;
}
if (count > 3)
{
    while (count>3)
    {
        a = a / 10;
        count = count - 1;
    }
    a = a % 10;
    Console.Write(" -> " + a);
}
else if (count == 3)
{
    a = a % 10;
    Console.Write(" -> " + a);
}
else
{
    Console.Write(" третьей цифры нет");
}