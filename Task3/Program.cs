Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int Chet = 0;
if (Chet==a%2)
{
    Console.WriteLine ($"Четное число? Yes");
}
else 
{
    Console.WriteLine ($"Четное число? No");
}

