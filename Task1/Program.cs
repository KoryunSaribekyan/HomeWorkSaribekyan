Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max>b)
{
   Console.WriteLine ($"max {a}, min {b}");
}
else if (max<b)
{
    Console.WriteLine ($"max {b}, min {a}");
}
else
    Console.WriteLine ("Значения равны");
