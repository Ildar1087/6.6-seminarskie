// задача 40 
// напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник со сторонами такой длины

Console.Clear();
Console.WriteLine("введите стороны треугольника через пробел: ");
string[] st = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int a = int.Parse(st[0]), b = int.Parse(st[1]),  c = int.Parse(st[2]);

if (IsTriange(a, b, c))
{
  System.Console.WriteLine("Да");
}
else
{
  System.Console.WriteLine("Нет");
}

bool IsTriange(int a, int b, int c)
{
  return (((a + b) > c) && ((a + c) > b) && ((c + b) > a));
}

