//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = 0;
int i = 10;
while (i < 100000000)
{
    if (n >= i * 100 && n < i * 1000)
    {
        n1 = n / i;
        Console.WriteLine(n1 % 10);
    }
    i = i * 10;
}
if (n >= 100 && n < 1000)
{
    Console.WriteLine(n % 10);
}
else if (n < 100)
{
    Console.WriteLine($"Третьей цифры не существует");
}