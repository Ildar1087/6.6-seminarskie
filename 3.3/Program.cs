// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10
Console.Clear();
System.Console.WriteLine("Введите число: ");

int n = int.Parse(Console.ReadLine());
string res = DecToNam(n, 2);
System.Console.WriteLine($"{n} -> {res}");

// универсальный математический для перевода из 10 в любую

string DecToNam(int decNamber, int otherSystem)
{
  string res = "";
  string nums = "0123456789ABCDEF";
  while(decNamber > 0)
  {
    int ost = decNamber / otherSystem;
    res = nums[decNamber - otherSystem * ost] + res;
    decNamber/=otherSystem;
  }
  return res;
}

// Console.WriteLine($"{Preobraz(n)}");