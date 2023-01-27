Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (a>b && a>c)
{
    max = a;
} 
else if (b>c)
{
    max = b;
}
else
max = c;
 Console.WriteLine ($"MAX = {max}");

