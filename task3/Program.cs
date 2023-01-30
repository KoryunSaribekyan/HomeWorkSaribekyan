/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 7)
{
    Console.Write($"Да.Воскресенье");
}
else if (n == 6)
{
    Console.Write($"Да.Суббота");
}
else if (n == 5)
{
    Console.Write($"Нет.Пятница");
}
else if (n == 4)
{
    Console.Write($"Нет.Четверг");
}
else if (n == 3)
{
    Console.Write($"Нет.Среда");
}
else if (n == 2)
{
    Console.Write($"Нет.Вторник");
}
else
{
    Console.Write($"Нет.Понедельник");
}