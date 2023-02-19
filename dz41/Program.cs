/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3   */


Console.Clear();
Console.WriteLine("вводите 6 чисел через пробел: ");
int[] st = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // превращаем строку в int массив

int sim = IsTriange(st);    // передаем функции наш массив
Console.WriteLine(String.Join(" ", sim));

int IsTriange(int[] array)      // функция по поиску положительных элементов массива
{
  int[] fgs = new int[array.Length];
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)           // ишем положительные элементы массива, путём его перебора
      count++;
  }
  return count;
}

